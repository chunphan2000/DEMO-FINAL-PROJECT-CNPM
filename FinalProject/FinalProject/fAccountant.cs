//using FinalProject.DAO;
using FinalProject.DAO;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class fAccountant : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); 
            }
        }
        public fAccountant(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadAddButton();
            LoadCategory();
            LoadDateTimePickerImport();
            LoadListBillByDate(dtpkFromDate1.Value, dtpkToDate1.Value);
        }

        #region Method
        void LoadCategory()
        {
            List<GoodsCategory> listCategory = GoodsCategoryDAO.Instance.GetListCategory();
            //Import
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
            //Export
            cbCategory2.DataSource = listCategory;
            cbCategory2.DisplayMember = "Name";
        } //fixed
        void LoadGoodsListByCategoryID(int id)
        {
            List<Goods> listGoods = GoodsDAO.Instance.GetGoodsByCategoryID(id);
            //Import
            cbGoods.DataSource = listGoods;
            cbGoods.DisplayMember = "Name";
            //Export
            cbGoods2.DataSource = listGoods;
            cbGoods2.DisplayMember = "Name";
        } //fixed
        void LoadAddButton()
        {
            //Import side
            flpAdd.Controls.Clear();
            List<Add> addList = AddDAO.Instance.LoadAddList();

            foreach (Add item in addList)
            {
                Button btn = new Button() { Width = AddDAO.TableWidth, Height = AddDAO.TableHeight };
                btn.Text = "Import" ;
                btn.Click += btn_Click;
                btn.Tag = item;
              
                flpAdd.Controls.Add(btn);
            }

            //Export side
            flpExport.Controls.Clear();
            List<Add2> addList2 = AddDAO2.Instance.LoadAddList();

            foreach (Add2 item2 in addList2)
            {
                Button btn2 = new Button() { Width = AddDAO2.TableWidth, Height = AddDAO2.TableHeight };
                btn2.Text = "Export";
                btn2.Click += btn2_Click;
                btn2.Tag = item2;

                flpExport.Controls.Add(btn2);
            }
        } //fixed
        float ShowImport(int id)
        {
            IsvImport.Items.Clear();
            List<Menuu> listImportInfor = MenuuDAO.Instance.GetListMenuByAdd(id);
            float totalPrice = 0;
            foreach (Menuu item in listImportInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                IsvImport.Items.Add(lsvItem);
            }
            return totalPrice;
        }
        float ShowExport(int id)
        {
            IsvExport.Items.Clear();
            List<Menuu> listExportInfor = MenuuDAO.Instance.GetListMenuByAdd2(id);
            float totalPrice = 0;
            foreach (Menuu item in listExportInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                IsvExport.Items.Add(lsvItem);
            }
            return totalPrice;
        }
        void LoadDateTimePickerImport()
        {
            DateTime today = DateTime.Now;
            //Import
            dtpkFromDate1.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate1.Value = dtpkFromDate1.Value.AddMonths(1).AddDays(-1);
            //Export
            dtpkFromDate2.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate2.Value = dtpkFromDate2.Value.AddMonths(1).AddDays(-1);
        } //fixed
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut) //fixed
        {
            //Import
            dtgvImport.DataSource = ImportDAO.Instance.GetBillListByDate(checkIn, checkOut);

            //Export
            dtgvExport.DataSource = ExportDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            
        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int addID = ((sender as Button).Tag as Add).ID;
            IsvImport.Tag = (sender as Button).Tag;
            ShowImport(addID);
        }
        void btn2_Click(object sender, EventArgs e)
        {
            int addID2 = ((sender as Button).Tag as Add2).ID;
            IsvExport.Tag = (sender as Button).Tag;
            ShowImport(addID2);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
           
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            GoodsCategory selected = cb.SelectedItem as GoodsCategory;
            id = selected.ID;

            LoadGoodsListByCategoryID(id);
        }

        private void btnAddToImport_Click(object sender, EventArgs e)
        {
            Add add = IsvImport.Tag as Add;

            int iDImport = ImportDAO.Instance.GetUncheckImportIDByAddID(add.ID);
            int iDGoods = (cbGoods.SelectedItem as Goods).ID;
            int count = (int)numGoodsCount.Value;

            if (iDImport == -1)
            {
                ImportDAO.Instance.InsertImport(add.ID);
                ImportInforDAO.Instance.InsertImportInfor(ImportDAO.Instance.GetMaxIDImport(), iDGoods, count);
            }
            else
            {
                ImportInforDAO.Instance.InsertImportInfor(iDImport, iDGoods, count);
            }

            ShowImport(add.ID);
            LoadAddButton();
            
        }
        private void btnAddToExport_Click(object sender, EventArgs e)
        {
            Add2 add2 = IsvExport.Tag as Add2;

            int iDExport = ExportDAO.Instance.GetUncheckExportIDByAddID(add2.ID);
            int iDGoods = (cbGoods.SelectedItem as Goods).ID;
            int count = (int)numGoodsCount2.Value;

            if (iDExport == -1)
            {
                ExportDAO.Instance.InsertExport(add2.ID);
                ExportInforDAO.Instance.InsertExportInfor(ExportDAO.Instance.GetMaxIDExport(), iDGoods, count);
            }
            else
            {
                ExportInforDAO.Instance.InsertExportInfor(iDExport, iDGoods, count);
            }

            ShowExport(add2.ID);
            LoadAddButton();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Add add = IsvImport.Tag as Add;

            int id = ImportDAO.Instance.GetUncheckImportIDByAddID(add.ID);
            double totalprice = Convert.ToDouble(ShowImport(add.ID));
            if (id != -1)
            {
                if (MessageBox.Show("Are you sure to save this bill?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ImportDAO.Instance.CheckOut(id,(float) totalprice);
                    
                    ShowImport(add.ID);
                    LoadAddButton();
                    LoadListBillByDate(dtpkFromDate1.Value, dtpkToDate1.Value);
                }
            }
        }
        private void btnSave2_Click(object sender, EventArgs e)
        {
            Add2 add2 = IsvExport.Tag as Add2;

            int id = ExportDAO.Instance.GetUncheckExportIDByAddID(add2.ID);
            double totalprice = Convert.ToDouble(ShowExport(add2.ID));
            if (id != -1)
            {
                if (MessageBox.Show("Are you sure to save this bill?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ExportDAO.Instance.CheckOut(id, (float)totalprice);

                    ShowExport(add2.ID);
                    LoadAddButton();
                    LoadListBillByDate(dtpkFromDate2.Value, dtpkToDate2.Value);
                }
            }
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate1.Value, dtpkToDate1.Value);
        }
        private void btnViewExport_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate2.Value, dtpkToDate2.Value);
        }

        #endregion


    }


}

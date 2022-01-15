using FinalProject.DAO;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class fAdmin : Form
    {
        BindingSource goodsList = new BindingSource();
        BindingSource cateList = new BindingSource();
        BindingSource staffList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();

            dtgvGoods.DataSource = goodsList;
            dtgvCate.DataSource = cateList;
            dtgvAccountant.DataSource = staffList;
            LoadListGoods();
            LoadListCate();
            LoadListStaff();
            AddGoodsBinding();
            AddCateBinding();
            AddStaffBinding();
            LoadCategoryIntoCombobox(cbCate);
        }

        #region Method
        private void accountantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadListGoods()
        {
            goodsList.DataSource = GoodsDAO.Instance.GetListGoods();
        }
        void LoadListCate()
        {
            cateList.DataSource = GoodsCategoryDAO.Instance.GetListCategory();
        }
        void LoadListStaff()
        {
            staffList.DataSource = StaffDAO.Instance.GetListStaff();
        }
        void AddGoodsBinding()
        {
            txtNameGoods.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtIDGoods.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtInventory.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "INVENTORY", true, DataSourceUpdateMode.Never));
            numUDimport.DataBindings.Add(new Binding("Value", dtgvGoods.DataSource, "PRICEIMPORT", true, DataSourceUpdateMode.Never));
            numUDDelivery.DataBindings.Add(new Binding("Value", dtgvGoods.DataSource, "PRICEDELIVERY", true, DataSourceUpdateMode.Never));

        }
        void AddCateBinding()
        {
            txtIDCate.DataBindings.Add(new Binding("Text", dtgvCate.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtNAMECate.DataBindings.Add(new Binding("Text", dtgvCate.DataSource, "Name", true, DataSourceUpdateMode.Never));
            
        }
        void AddStaffBinding()
        {
            txtNameAccountant.DataBindings.Add(new Binding("Text", dtgvAccountant.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtIDAccountant.DataBindings.Add(new Binding("Text", dtgvAccountant.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtPhoneAccountant.DataBindings.Add(new Binding("Text", dtgvAccountant.DataSource, "phone", true, DataSourceUpdateMode.Never));
            txtAddressAccountant.DataBindings.Add(new Binding("Text", dtgvAccountant.DataSource, "ADDRESS", true, DataSourceUpdateMode.Never));

        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = GoodsCategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Event

        private void txtIDGoods_TextChanged(object sender, EventArgs e)
        {
            if (dtgvGoods.SelectedCells.Count > 0)
            {
                int id = (int)dtgvGoods.SelectedCells[0].OwningRow.Cells["IDCATEGORY"].Value;

                GoodsCategory cateogory = GoodsCategoryDAO.Instance.GetCategoryByID(id);

                cbCate.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (GoodsCategory item in cbCate.Items)
                {
                    if (item.ID == cateogory.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbCate.SelectedIndex = index;
            }
        }
        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            string name = txtNameGoods.Text;
            int iDCategory = (cbCate.SelectedItem as GoodsCategory).ID;
            string inventory = txtInventory.Text;
            int priceImport = (int)numUDimport.Value;
            int priceDelivery = (int)numUDDelivery.Value;

            if (GoodsDAO.Instance.InsertGoods(name, iDCategory, inventory, priceImport, priceDelivery))
            {
                MessageBox.Show("Successful Addition");
                LoadListGoods();
            }
            else
            {
                MessageBox.Show("Something was wrong!");
            }
        }
        private void btnEditGoods_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDGoods.Text);
            string name = txtNameGoods.Text;
            int iDCategory = (cbCate.SelectedItem as GoodsCategory).ID;
            string inventory = txtInventory.Text;
            int priceImport = (int)numUDimport.Value;
            int priceDelivery = (int)numUDDelivery.Value;

            if (GoodsDAO.Instance.UpdateGoods(id, name, iDCategory, inventory, priceImport, priceDelivery))
            {
                MessageBox.Show("Edited Successfully!");
                LoadListGoods();

            }
            else
            {
                MessageBox.Show("Something was wrong!");
            }
        }


        private void btnADDCate_Click(object sender, EventArgs e)
        {
            string name = txtNAMECate.Text;            

            if (GoodsCategoryDAO.Instance.InsertCate(name))
            {
                MessageBox.Show("Successful Addition");
                LoadListCate();
                LoadCategoryIntoCombobox(cbCate);
            }
            else
            {
                MessageBox.Show("Something was wrong!");
            }
        }

        private void btnEDITCate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDCate.Text);
            string name = txtNAMECate.Text;           

            if (GoodsCategoryDAO.Instance.UpdateCate(id, name))
            {
                MessageBox.Show("Edited Successfully!");
                LoadListCate();
                LoadCategoryIntoCombobox(cbCate);

            }
            else
            {
                MessageBox.Show("Something was wrong!");
            }
        }

        private void btnADDAccountant_Click(object sender, EventArgs e)
        {
            string name = txtNameAccountant.Text;           
            int phone = int.Parse(txtPhoneAccountant.Text);
            string address = txtAddressAccountant.Text;

            if (StaffDAO.Instance.InsertStaff(name, phone, address))
            {
                MessageBox.Show("Successful Addition");
                LoadListStaff();               
            }
            else
            {
                MessageBox.Show("Something was wrong!");
            }
        }
               
        private void btnEDITAccountant_Click(object sender, EventArgs e)
        {          
            int id = Convert.ToInt32(txtIDAccountant.Text);
            string name = txtNameAccountant.Text;
            int phone = int.Parse(txtPhoneAccountant.Text);
            string address = txtAddressAccountant.Text;

            if (StaffDAO.Instance.UpdateStaff(id, name,phone, address))
            {
                MessageBox.Show("Edited Successfully!");
                LoadListStaff();

            }
            else
            {
                MessageBox.Show("Something was wrong!");
            }
           
        }
        #endregion
    }
}

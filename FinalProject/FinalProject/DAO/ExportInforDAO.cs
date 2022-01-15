using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class ExportInforDAO
    {
        private static ExportInforDAO instance;

        public static ExportInforDAO Instance
        {
            get { if (instance == null) instance = new ExportInforDAO(); return ExportInforDAO.instance; }
            private set { ExportInforDAO.instance = value; }
        }

        private ExportInforDAO() { }

        public List<ExportInfor> GetListExportInfor(int id)
        {
            List<ExportInfor> listExportInfor = new List<ExportInfor>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EXPORTINFOR WHERE IDEXPORT = " + id);

            foreach (DataRow item in data.Rows)
            {
                ExportInfor info = new ExportInfor(item);
                listExportInfor.Add(info);
            }

            return listExportInfor;
        }
        public void InsertExportInfor(int iDExport, int iDGoods, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertExportInfor @IDEXPORT , @IDGOODS , @COUNT", new object[] { iDExport, iDGoods, count });
        }
    }
}

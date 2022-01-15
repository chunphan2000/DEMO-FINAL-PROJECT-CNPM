using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class ImportInforDAO
    {
        private static ImportInforDAO instance;

        public static ImportInforDAO Instance
        {
            get { if (instance == null) instance = new ImportInforDAO(); return ImportInforDAO.instance; }
            private set { ImportInforDAO.instance = value; }
        }

        private ImportInforDAO() { }

        public List<ImportInfor> GetListImportInfor(int id)
        {
            List<ImportInfor> listImportInfor = new List<ImportInfor>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.IMPORTINFOR WHERE IDIMPORT = " + id);

            foreach (DataRow item in data.Rows)
            {
                ImportInfor info = new ImportInfor(item);
                listImportInfor.Add(info);
            }

            return listImportInfor;
        }
        public void InsertImportInfor(int iDImport, int iDGoods, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertImportInfor @IDIMPORT , @IDGOODS , @COUNT", new object[] { iDImport, iDGoods, count });
        }
    }
}

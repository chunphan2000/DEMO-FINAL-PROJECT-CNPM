using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    class ImportDAO
    {
        private static ImportDAO instance;

        public static ImportDAO Instance
        {
            get { if (instance == null) instance = new ImportDAO(); return ImportDAO.instance; }
            private set { ImportDAO.instance = value; }
        }
        private ImportDAO() { }

        public int GetUncheckImportIDByAddID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.IMPORT WHERE IDADDIMPORT = " + id + " AND STATUS = 0");

            if (data.Rows.Count > 0)
            {
                Import import = new Import(data.Rows[0]);
                return import.ID;
            }

            return -1;
        }
        public void InsertImport(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertImport @IDADDIMPORT", new object[] { id });
        }
        public int GetMaxIDImport()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM dbo.IMPORT");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id, float totalprice)
        {
            string query = "UPDATE dbo.IMPORT SET STATUS = 1, "+"TOTALPRICE = "+ totalprice+"WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}

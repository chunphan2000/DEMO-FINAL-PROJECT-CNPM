using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    class ExportDAO
    {
        private static ExportDAO instance;

        public static ExportDAO Instance
        {
            get { if (instance == null) instance = new ExportDAO(); return ExportDAO.instance; }
            private set { ExportDAO.instance = value; }
        }
        private ExportDAO() { }

        public int GetUncheckExportIDByAddID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EXPORT WHERE IDADDEXPORT = " + id + " AND STATUS = 0");

            if (data.Rows.Count > 0)
            {
                Export export = new Export(data.Rows[0]);
                return export.ID;
            }

            return -1;
        }
        public void InsertExport(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertExport @IDADDEXPORT", new object[] { id });
        }
        public int GetMaxIDExport()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM dbo.EXPORT");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id, float totalprice)
        {
            string query = "UPDATE dbo.EXPORT SET STATUS = 1, " + "TOTALPRICE = " + totalprice + "WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate2 @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}

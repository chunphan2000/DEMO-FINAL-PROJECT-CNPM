using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO() { }


        public List<Staff> GetListStaff()
        {
            List<Staff> list = new List<Staff>();

            string query = "select * from ACCOUNTANT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }

            return list;
        }
        public bool InsertStaff(string name, int phone, string address)
        {
            string query = string.Format("INSERT INTO dbo.ACCOUNTANT (NAME, PHONE_NUMBER, ADDRESS) " +
                                         "VALUES  ('{0}', {1}, '{2}')", name, phone, address);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateStaff(int id, string name, int phone, string address)
        {
            string query = string.Format("UPDATE dbo.ACCOUNTANT SET " +
                "NAME = '{0}', PHONE_NUMBER = {1}, ADDRESS ='{2}' WHERE ID_ACCOUNTANT = {3}", name, phone, address, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
 }

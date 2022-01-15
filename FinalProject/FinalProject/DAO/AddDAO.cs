using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class AddDAO
    {
        public static int TableWidth = 88;
        public static int TableHeight = 40;
        private static AddDAO instance;

        public static AddDAO Instance
        {
            get { if (instance == null) instance = new AddDAO(); return AddDAO.instance; }
            private set { AddDAO.instance = value; }

            
    }
        private AddDAO() { }

    public List<Add> LoadAddList()
        {
            List<Add> addList = new List<Add>();
           
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetAddList");
            foreach (DataRow item in data.Rows)
            {
                Add table = new Add(item);
                addList.Add(table);
            }


            return addList;
        }
    }
}

using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class AddDAO2
    {
        public static int TableWidth = 88;
        public static int TableHeight = 40;
        private static AddDAO2 instance;

        public static AddDAO2 Instance
        {
            get { if (instance == null) instance = new AddDAO2(); return AddDAO2.instance; }
            private set { AddDAO2.instance = value; }


        }
        private AddDAO2() { }

        public List<Add2> LoadAddList()
        {
            List<Add2> addList = new List<Add2>();

            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetExportList");
            foreach (DataRow item in data.Rows)
            {
                Add2 table = new Add2(item);
                addList.Add(table);
            }


            return addList;
        }
    }
}

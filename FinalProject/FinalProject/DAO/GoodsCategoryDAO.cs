using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class GoodsCategoryDAO
    {
        private static GoodsCategoryDAO instance;

        public static GoodsCategoryDAO Instance
        {
            get { if (instance == null) instance = new GoodsCategoryDAO(); return GoodsCategoryDAO.instance; }
            private set { GoodsCategoryDAO.instance = value; }
        }

        private GoodsCategoryDAO() { }

        public List<GoodsCategory> GetListCategory()
        {
            List<GoodsCategory> list = new List<GoodsCategory>();

            string query = "select * from [GOODSCATEGORY]";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GoodsCategory category = new GoodsCategory(item);
                list.Add(category);
            }

            return list;
        }
        public GoodsCategory GetCategoryByID(int id)
        {
            GoodsCategory category = null;

            string query = "select * from GOODSCATEGORY where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new GoodsCategory(item);
                return category;
            }

            return category;
        }
        public bool InsertCate(string name)
        {
            string query = string.Format("INSERT INTO dbo.GOODSCATEGORY (NAME) " +
                                         "VALUES  ('{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCate(int id, string name)
        {
            string query = string.Format("UPDATE dbo.GOODSCATEGORY SET " +
                "NAME = '{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

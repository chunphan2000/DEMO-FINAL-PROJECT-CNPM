using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class GoodsDAO
    {
        private static GoodsDAO instance;

        public static GoodsDAO Instance
        {
            get { if (instance == null) instance = new GoodsDAO(); return GoodsDAO.instance; }
            private set { GoodsDAO.instance = value; }
        }

        private GoodsDAO() { }

        public List<Goods> GetGoodsByCategoryID(int id)
        {
            List<Goods> list = new List<Goods>();

            string query = "select * from [GOODS] where IDCATEGORY = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Goods goods = new Goods(item);
                list.Add(goods);
            }

            return list;
        }

        public List<Goods> GetListGoods()
        {
            List<Goods> list = new List<Goods>();

            string query = "select * from GOODS";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Goods goods = new Goods(item);
                list.Add(goods);
            }

            return list;
        }

        public bool InsertGoods(string name, int iDCategory, string inventory, int priceImport, int priceDelivery)
        {
            string query = string.Format("INSERT INTO dbo.GOODS (NAME, IDCATEGORY, INVENTORY, UPRICE_IMPORT, UPRICE_DELIVERY) " +
                                         "VALUES  ('{0}', {1}, '{2}', {3}, {4})", name, iDCategory, inventory, priceImport, priceDelivery);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateGoods(int id, string name, int iDCategory, string inventory, int priceImport, int priceDelivery)
        {
            string query = string.Format("UPDATE dbo.GOODS SET " +
                "NAME = '{0}', IDCATEGORY = {1}, INVENTORY ='{2}', UPRICE_IMPORT = {3}, UPRICE_DELIVERY = {4} WHERE id = {5}", name, iDCategory, inventory, priceImport, priceDelivery, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

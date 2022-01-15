using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class MenuuDAO
    {
        private static MenuuDAO instance;

        public static MenuuDAO Instance
        {
            get { if (instance == null) instance = new MenuuDAO(); return MenuuDAO.instance; }
            private set { MenuuDAO.instance = value; }
        }

        private MenuuDAO() { }

        public List<Menuu> GetListMenuByAdd(int id)
        {
            List<Menuu> listMenu = new List<Menuu>();

            string query = "SELECT g.[NAME], ii.[COUNT] AS count, g.[UPRICE_IMPORT] AS price, g.[UPRICE_IMPORT]*ii.count AS totalprice  FROM dbo.IMPORTINFOR AS ii, dbo.IMPORT AS i, dbo.GOODS AS g WHERE ii.IDIMPORT = i.ID AND ii.IDGOODS = g.ID AND i.IDADDIMPORT = " + id + "AND i.STATUS = 0" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menuu menu = new Menuu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<Menuu> GetListMenuByAdd2(int id)
        {
            List<Menuu> listMenu = new List<Menuu>();

            string query = "SELECT g.[NAME], ee.[COUNT] AS count, g.[UPRICE_DELIVERY] AS price, g.[UPRICE_DELIVERY]*ee.count AS totalprice  " +
                "FROM dbo.EXPORTINFOR AS ee, dbo.EXPORT AS e, dbo.GOODS AS g WHERE ee.IDEXPORT = e.ID AND ee.IDGOODS = g.ID AND e.IDADDEXPORT = " + id + "AND e.STATUS = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menuu menu = new Menuu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}

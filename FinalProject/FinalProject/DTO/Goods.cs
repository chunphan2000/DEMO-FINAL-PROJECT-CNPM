using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class Goods
    {
        public Goods(int id, string name, int iDCategory, string inventory, int priceImport, int priceDelivery)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = iDCategory;
            this.Inventory = inventory;
            this.PriceImport = priceImport;
            this.PriceDelivery = priceDelivery;
        }

        public Goods(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IDCategory = (int)row["iDCategory"];
            this.Inventory = row["INVENTORY"].ToString();
            this.PriceImport = (int)row["UPRICE_IMPORT"];
            this.PriceDelivery = (int)row["UPRICE_Delivery"];
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iDCategory;

        public int IDCategory
        {
            get { return iDCategory; }
            set { iDCategory = value; }
        }
        private string inventory;

        public string Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        private int priceImport;

        public int PriceImport
        {
            get { return priceImport; }
            set { priceImport = value; }
        }
        private int priceDelivery;

        public int PriceDelivery
        {
            get { return priceDelivery; }
            set { priceDelivery = value; }
        }
    }
}

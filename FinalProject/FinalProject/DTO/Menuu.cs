using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class Menuu
    {
        public Menuu (string name, int count, int price, int totalprice)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalprice;
        }

        public Menuu(DataRow row)
        {
            this.Name = (string)row ["name"];
            this.Count = (int)row["count"];
            this.Price = (int) row["price"];
            this.TotalPrice = (int)row["totalprice"];
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string name;
        private DataRow item;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int totalprice;
        public int TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
    }
}

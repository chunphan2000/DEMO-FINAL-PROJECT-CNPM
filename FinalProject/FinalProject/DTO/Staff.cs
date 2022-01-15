using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class Staff
    {
        public Staff(int id, string name, int phone, string address)
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;           
        }

        public Staff(DataRow row)
        {
            this.ID = (int)row["ID_ACCOUNTANT"];
            this.Name = row["name"].ToString();
            this.Phone = (int)row["PHONE_NUMBER"];
            this.Address = row["address"].ToString();

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

        private int phone;

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class Add2
    {
        public Add2(int id, string name)
        {
            this.ID = id;
            this.name = name;
        }

        public Add2(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }



        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;
        private DataRow item;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class ImportInfor
    {
        public ImportInfor(int iDGoods, int iDImport, int iD, int count)
        {
            this.IDGoods = iDGoods;
            this.IDImport = iDImport;
            this.ID = iD;
            this.Count = count;
        }

        public ImportInfor(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.IDGoods = (int)row["iDGoods"];
            this.IDImport = (int)row["iDImport"];
            this.Count = (int)row["count"];
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int iDGoods;
        public int IDGoods
        {
            get { return iDGoods; }
            set { iDGoods = value; }
        }
        private int iDImport;
        public int IDImport
        {
            get { return iDImport; }
            set { iDImport = value; }
        }
        private int iD;
        private DataRow item;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}

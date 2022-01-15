using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class ExportInfor
    {
        public ExportInfor(int iDGoods, int iDExport, int iD, int count)
        {
            this.IDGoods = iDGoods;
            this.IDExport = iDExport;
            this.ID = iD;
            this.Count = count;
        }

        public ExportInfor(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.IDGoods = (int)row["iDGoods"];
            this.IDExport = (int)row["iDExport"];
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
        private int iDExport;
        public int IDExport
        {
            get { return iDExport; }
            set { iDExport = value; }
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

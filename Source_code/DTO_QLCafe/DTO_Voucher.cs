using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCafe
{
    public class DTO_Voucher
    {
        public string idVoucher { get; set; }
        public string nameVoucher { get; set;}
        public int percentVoucher { get; set; }
        public int statusVoucher { get; set; }

        public string IdVoucher 
        {
            get { return idVoucher; }
            set { idVoucher = value; }
        }
        public string NameVoucher
        {
            get { return nameVoucher; }
            set { nameVoucher = value; }
        }
        public int PercentVoucher
        {
            get { return percentVoucher; }
            set { percentVoucher = value; }
        }
        public int StatusVoucher
        {
            get { return statusVoucher; }
            set { statusVoucher = value; }
        }
        public DTO_Voucher(string idVoucher, string nameVoucher, int percentVoucher, int statusVoucher)
        {
            this.idVoucher = idVoucher;
            this.nameVoucher = nameVoucher;
            this.percentVoucher = percentVoucher;
            this.statusVoucher = statusVoucher;
        }
    }
}

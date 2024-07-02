using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLCafe
{
    public class BUS_Voucher
    {
        DAL_Voucher dal = new DAL_Voucher();
        public DataTable get()
        {
            return dal.get();
        }
        public bool insert(DTO_Voucher obj)
        {
            return dal.insert(obj);
        }
        public bool update(DTO_Voucher obj)
        {
            return dal.update(obj);
        }
        public DataTable search(string keyword, string column)
        {
            return dal.search(keyword, column);
        }
    }
}

﻿using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;
namespace BUS_QLCafe
{
    public class BUS_Payment
    {
        DAL_Payment dal = new DAL_Payment();

        public DataTable get()
        {
            return dal.get();
        }
        public bool insert(DTO_Payment obj)
        {
            return dal.insert(obj);
        }

        public bool update(DTO_Payment obj)
        {
            return dal.update(obj);
        }

        public bool delete(string obj)
        {
            return dal.delete(obj);
        }

        public DataTable search(string keyword, string column)
        {
            return dal.search(keyword, column);
        }

        public DataTable ListVoucher()
        {
            return dal.ListVoucher();
        }

        public DataTable ListPayment()
        {
            return dal.ListPayment();
        }

        public bool Payment(DTO_Bill bill)
        {
            return dal.Payment(bill);
        }
    }
}

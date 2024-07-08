﻿using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace BUS_QLCafe
{
    public class BUS_Bill
    {
        DAL_Bill dal = new DAL_Bill();

        public DataTable get()
        {
            return dal.get();
        }

        public bool insert(DTO_Bill bill)
        {
            return dal.insert(bill);
        }

        public bool update(DTO_Bill bill)
        {
            return dal.update(bill);
        }

        public bool delete(string obj)
        {
            return dal.delete(obj);
        }
        public DataTable search(string keyword, string column)
        {
            return dal.search(keyword, column);
        }
    }
}
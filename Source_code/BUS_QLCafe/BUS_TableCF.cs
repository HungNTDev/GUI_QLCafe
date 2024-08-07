﻿using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;
namespace BUS_QLCafe
{
    public class BUS_TableCF
    {
        DAL_TableCF dal = new DAL_TableCF();
        public DataTable get()
        {
            return dal.get();
        }

        public bool insert(DTO_TableCF obj)
        {
            return dal.insert(obj);
        }

        public bool update(DTO_TableCF obj)
        {
            return dal.update(obj);
        }

        public bool delete(string obj)
        {
            return dal.delete(obj);
        }

        public DataTable search(string keyword)
        {
            return dal.search(keyword);
        }

        public DataTable TableList()
        {
            return dal.TableList();
        }

        public DataTable TableInfo(DTO_Bill bill)
        {
            return dal.TableInfo(bill);
        }

        public DataTable GetPage(int page, int pageSize)
        {
            return dal.GetPagedTable(page, pageSize);
        }

        public bool KiemTra(string name)
        {
            return dal.KiemtraTrungTenBan(name);
        }

        public DataTable getIdTable(out string Next)
        {
            return dal.getIdTable(out Next);
        }
    }
}

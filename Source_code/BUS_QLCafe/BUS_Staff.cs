using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLCafe
{
    public class BUS_Staff
    {
        DAL_Staff dalStaff = new DAL_Staff();

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encoding = new UTF8Encoding();
            //encrypt the given password string into Encrypted Data
            encrypt = md5.ComputeHash(encoding.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create new string by using encryted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        public bool DangNhap(DTO_Staff staff)
        {
            return dalStaff.dangNhap(staff);
        }
        public bool QuenMK(string email)
        {
            return dalStaff.quenMK(email);
        }
        public bool CapNhatMK(string email, string matkhau)
        {
            return dalStaff.capNhatMK(email, matkhau);
        }
        public DataTable VaiTro(string email)
        {
            return dalStaff.vaiTro(email);
        }
        public DataTable LayMK(string emal)
        {
            return dalStaff.layMK(emal);
        }
        public DataTable LayID()
        {
            return dalStaff.layID();
        }
        public DataTable get()
        {
            return dalStaff.get();
        }
        public bool insert(DTO_Staff staff)
        {
            return dalStaff.insert(staff);
        }
        public bool update(DTO_Staff staff)
        {
            return dalStaff.update(staff);
        }
        public DataTable search(string keyword, string column)
        {
            return dalStaff.search(keyword, column);
        }
    }
}

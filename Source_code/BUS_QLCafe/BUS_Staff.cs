using DAL_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLCafe
{
    public class BUS_Staff
    {
        DAL_Staff dalStaff = new DAL_Staff();
        //xử lí md5
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
        public void DangNhap()
        {

        }
        public void QuenMK()
        {

        }
        public void CapNhatMK()
        {

        }
        public void VaiTro()
        {

        }
        public void LayMK()
        {

        }
        public void GetID()
        {

        }
        public void get()
        {

        }
        public void insert()
        {

        }
        public void update()
        {

        }
        public void delete()
        {

        }
        public void search()
        {

        }
    }
}

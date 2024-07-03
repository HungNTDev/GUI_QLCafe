using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BUS_QLCafe
{
    public class BUS_Staff
    {
        DAL_Staff dal = new DAL_Staff();

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
            return dal.dangNhap(staff);
        }
        public bool QuenMK(string email)
        {
            return dal.quenMK(email);
        }
        public bool CapNhatMK(string email, string matkhau)
        {
            return dal.capNhatMK(email, matkhau);
        }

        public bool updateNewMK(string email, string matkhaucu, string matkhaumoi)
        {
            return dal.UpdateMK(email, matkhaucu, matkhaumoi);
        }
        public DataTable VaiTro(string email)
        {
            return dal.vaiTro(email);
        }
        public DataTable LayMK(string email)
        {
            return dal.layMK(email);
        }
        public DataTable LayID()
        {
            return dal.layID();
        }
        public bool KiemTraEmail(string email)
        {
            return dal.kiemtraEmail(email);
        }
        public DataTable get()
        {
            return dal.get();
        }
        public bool insert(DTO_Staff staff)
        {
            return dal.insert(staff);
        }
        public bool update(DTO_Staff staff)
        {
            return dal.update(staff);
        }
        public DataTable search(string keyword, string column)
        {
            return dal.search(keyword, column);
        }
    }
}

using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCafe
{
    public class DAL_ProductType: DBConnect
    {
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    DataTable dtNhanVien = new DataTable();
                    dtNhanVien.Load(cmd.ExecuteReader());
                    return dtNhanVien;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public bool insert(DTO_ProductType obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NamePT", obj.NamePT);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool delete(DTO_Staff staff)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DeleteVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FullName", staff.FullName);
                    cmd.Parameters.AddWithValue("@ImageStaff", staff.ImageStaff);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@PasswordStaff", staff.PasswordStaff);
                    cmd.Parameters.AddWithValue("@RoleStaff", staff.RoleStaff);
                    cmd.Parameters.AddWithValue("@StatusStaff", staff.StatusStaff);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool update(DTO_ProductType obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdateVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@IdPT", obj.IdPT);
                    cmd.Parameters.AddWithValue("@NamePT", obj.NamePT);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public DataTable search(string keyword, string column)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SearchVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    cmd.Parameters.AddWithValue("@column", column);

                    conn.Open();

                    DataTable dtNhanVien = new DataTable();
                    dtNhanVien.Load(cmd.ExecuteReader());
                    return dtNhanVien;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}

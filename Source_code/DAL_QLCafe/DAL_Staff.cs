using DTO_QLCafe;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_Staff
    {
        private SqlConnection conn = new SqlConnection("server=CHIBAO\\SQLEXPRESS; database=QLBH; integrated security=true");

        public bool dangNhap(DTO_Staff staff)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DangNhap", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", staff.Email);
                    cmd.Parameters.AddWithValue("@matkhau", staff.PasswordStaff);

                    conn.Open();

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0; //nếu result > 0 thì trả về true và ngược lại
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
        public bool quenMK(string email)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("QuenMK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);
                    conn.Open();

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0; //nếu result > 0 thì trả về true và ngược lại
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
        public DataTable layMK(string email)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("LayMK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);

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
        public bool capNhatMK(string email, string matkhau)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("CapNhatMK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@matkhau", matkhau);

                    conn.Open();


                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0; //nếu result > 0 thì trả về true và ngược lại
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
        public DataTable vaiTro(string email)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("VaiTro", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);

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
        public DataTable layID()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("LayID", conn))
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
        public bool kiemtraEmail(string email)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("KiemTraEmail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();


                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result == 1; //nếu result > 0 thì trả về true và ngược lại
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
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("getStaff", conn))
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
        public bool insert(DTO_Staff staff)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FullName", staff.FullName);
                    cmd.Parameters.AddWithValue("@ImageStaff", staff.ImageStaff);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@PasswordStaff", staff.PasswordStaff);
                    cmd.Parameters.AddWithValue("@RoleStaff", staff.RoleStaff);
                    cmd.Parameters.AddWithValue("@StatusStaff", staff.StatusStaff);

                    conn.Open();

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0; //nếu result > 0 thì trả về true và ngược lại
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
        public bool update(DTO_Staff staff)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdateStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@IdStaff", staff.IdStaff);
                    cmd.Parameters.AddWithValue("@FullName", staff.FullName);
                    cmd.Parameters.AddWithValue("@ImageStaff", staff.ImageStaff);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@PasswordStaff", staff.PasswordStaff);
                    cmd.Parameters.AddWithValue("@RoleStaff", staff.RoleStaff);
                    cmd.Parameters.AddWithValue("@StatusStaff", staff.StatusStaff);

                    conn.Open();

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0; //nếu result > 0 thì trả về true và ngược lại
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
        public DataTable search(string keyword, string column)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SearchStaff", conn))
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

using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_Staff : DBConnect
    {
        public bool dangNhap(DTO_Staff staff)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DangNhap", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", staff.Email);
                    cmd.Parameters.AddWithValue("@password", staff.PasswordStaff);

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
        public bool quenMK(string email)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("QuenMK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);
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

        //Lấy mk để kiểm tra mật khẩu cũ có đúng không? (Cho chức năng đổi mật khẩu)
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

        public bool UpdateMK(string email, string matkhaucu, string matkhaumoi)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ChangePass", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@opwd", matkhaucu);
                    cmd.Parameters.AddWithValue("@npwd", matkhaumoi);

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
        public bool capNhatMK(string email, string matkhaumoi)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("NewPass", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", matkhaumoi);

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

                    int count = (int)cmd.ExecuteScalar();
                    if (count == 1)
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
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetStaff", conn))
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
                using (SqlCommand cmd = new SqlCommand("InsertStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdStaff", staff.IdStaff);

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

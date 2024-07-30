using DTO_QLCafe;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_Voucher : DBConnect
    {
        SqlConnection conn;
        public int GetTotalVoucherCount()
        {
            int totalVoucherCount = 0;
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetTotalVoucherCount";
                    conn.Open();
                    totalVoucherCount = (int)cmd.ExecuteScalar();
                    return totalVoucherCount;
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
        public DataTable GetPagedVoucher(int PageIndex, int PageSize)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetPagedVoucher";
                    cmd.Parameters.AddWithValue("@PageIndex", PageIndex);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
                    return dt;
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetVoucher";
                    conn.Open();
                    DataTable dtVoucher = new DataTable();
                    dtVoucher.Load(cmd.ExecuteReader());
                    return dtVoucher;
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
        public bool KiemTraVoucher(string id)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "KiemTraVoucher";
                    cmd.Parameters.AddWithValue("@IdVoucher", id);
                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();
                    if (Convert.ToInt16(count) > 0)
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
        public bool insert(DTO_Voucher obj)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertVoucher";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@IdVoucher", obj.IdVoucher);
                    cmd.Parameters.AddWithValue("@NameVoucher", obj.NameVoucher);
                    cmd.Parameters.AddWithValue("@PercentVoucher", obj.PercentVoucher);
                    cmd.Parameters.AddWithValue("@StatusVoucher", obj.StatusVoucher);

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
        public bool update(DTO_Voucher obj)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateVoucher";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@IdVoucher", obj.IdVoucher);
                    cmd.Parameters.AddWithValue("@NameVoucher", obj.NameVoucher);
                    cmd.Parameters.AddWithValue("@PercentVoucher", obj.PercentVoucher);
                    cmd.Parameters.AddWithValue("@StatusVoucher", obj.StatusVoucher);

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
        public bool delete(string id)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteVoucher";
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@IdVoucher", id);
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
        public DataTable search(string value, int pageNumber, int pageSize, out int totalRows, out int totalPages)
        {
            totalRows = 0;
            totalPages = 0;

            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SearchVoucher", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add input parameters
                        cmd.Parameters.AddWithValue("@value", value);
                        cmd.Parameters.AddWithValue("@pageNumber", pageNumber);
                        cmd.Parameters.AddWithValue("@pageSize", pageSize);

                        // Add output parameters
                        SqlParameter totalRowsParam = new SqlParameter("@totalRows", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(totalRowsParam);

                        SqlParameter totalPagesParam = new SqlParameter("@totalPages", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(totalPagesParam);

                        // Open connection and execute query
                        conn.Open();
                        DataTable dtNhanVien = new DataTable();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dtNhanVien.Load(reader);
                        }

                        // Retrieve output parameter values
                        totalRows = (int)totalRowsParam.Value;
                        totalPages = (int)totalPagesParam.Value;

                        return dtNhanVien;
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
        }
    }
}

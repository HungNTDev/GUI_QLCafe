using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_Voucher : DBConnect
    {
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

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
        public bool insert(DTO_Voucher obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

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
                using (SqlCommand cmd = new SqlCommand("UpdateVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

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
                using (SqlCommand cmd = new SqlCommand("DeleteVoucher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

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
    }
}

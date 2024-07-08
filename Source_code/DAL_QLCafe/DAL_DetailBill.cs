using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLCafe
{
    public class DAL_DetailBill : DBConnect
    {
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetDetailBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    DataTable dtDetailBill = new DataTable();
                    dtDetailBill.Load(cmd.ExecuteReader());
                    return dtDetailBill;
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

        public bool insert(DTO_DetailBill obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertDetailBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdBill", obj.IdBill);
                    cmd.Parameters.AddWithValue("@IdProduct", obj.IdProduct);
                    cmd.Parameters.AddWithValue("@TotalPrice", obj.TotalPrice);
                    cmd.Parameters.AddWithValue("@Amount", obj.Amount);
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

        public bool update(DTO_DetailBill obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdateDetailBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdBill", obj.IdBill);
                    cmd.Parameters.AddWithValue("@IdProduct", obj.IdProduct);
                    cmd.Parameters.AddWithValue("@TotalPrice", obj.TotalPrice);
                    cmd.Parameters.AddWithValue("@Amount", obj.Amount);
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

        public bool delete(string obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DeleteDetailBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdBill", obj);

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
                }
            }
            return false;
        }

        public DataTable search(string obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SearchDetailBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdBill", obj);

                    conn.Open();
                    DataTable dtDetailBill = new DataTable();
                    dtDetailBill.Load(cmd.ExecuteReader());
                    return dtDetailBill;
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

using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLCafe
{
    public class DAL_DetailBill : DBConnect
    {
        SqlConnection conn;
        public DataTable get()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand("GetDetailBill", conn);
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertDetailBill";
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateDetailBill";
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteDetailBill";
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchDetailBill";
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

        //Thêm detail bill
        public bool AddingDetailBill(DTO_DetailBill detailBill)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AddingDetailBill";
                    cmd.Parameters.AddWithValue("@IdTable", detailBill.IdBill);
                    cmd.Parameters.AddWithValue("@IdProduct", detailBill.IdProduct);
                    cmd.Parameters.AddWithValue("@Amount", detailBill.Amount);
                    cmd.Parameters.AddWithValue("@TotalPrice", detailBill.TotalPrice);
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
    }
}

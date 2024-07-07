using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_Payment : DBConnect
    {
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetPayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    DataTable dtPayment = new DataTable();
                    dtPayment.Load(cmd.ExecuteReader());
                    return dtPayment;
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

        public bool insert(DTO_Payment obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertPayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdPayment", obj.IdPayment);
                    cmd.Parameters.AddWithValue("@TypePayment", obj.TypePayment);
                    cmd.Parameters.AddWithValue("@StatusPayment", obj.StatusPayment);

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

        public bool update(DTO_Payment obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdatePayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdPayment", obj.IdPayment);
                    cmd.Parameters.AddWithValue("@TypePayment", obj.TypePayment);
                    cmd.Parameters.AddWithValue("@StatusPayment", obj.StatusPayment);

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

        public bool delete(DTO_Payment obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DeletePayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdPayment", obj.IdPayment);
                    cmd.Parameters.AddWithValue("@TypePayment", obj.TypePayment);
                    cmd.Parameters.AddWithValue("@StatusPayment", obj.StatusPayment);

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
                using (SqlCommand cmd = new SqlCommand("SearchPayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    cmd.Parameters.AddWithValue("@column", column);

                    conn.Open();

                    DataTable dtPayment = new DataTable();
                    dtPayment.Load(cmd.ExecuteReader());
                    return dtPayment;
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

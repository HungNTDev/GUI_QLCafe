using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_TableCF : DBConnect
    {
        public DataTable get()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetTableCF", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    DataTable dtTableCF = new DataTable();
                    dtTableCF.Load(cmd.ExecuteReader());
                    return dtTableCF;
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

        public bool insert(DTO_TableCF obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertTableCF", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdTable", obj.IdTable);
                    cmd.Parameters.AddWithValue("@NameTable", obj.NameTable);
                    cmd.Parameters.AddWithValue("@StatusTable", obj.StatusTable);

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

        public bool update(DTO_TableCF obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdateTableCF", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdTable", obj.IdTable);
                    cmd.Parameters.AddWithValue("@NameTable", obj.NameTable);
                    cmd.Parameters.AddWithValue("@StatusTable", obj.StatusTable);

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
                using (SqlCommand cmd = new SqlCommand("DeleteTableCF", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdTable", id);

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
                using (SqlCommand cmd = new SqlCommand("SearchTableCF", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    cmd.Parameters.AddWithValue("@column", column);

                    conn.Open();

                    DataTable dtTableCF = new DataTable();
                    dtTableCF.Load(cmd.ExecuteReader());
                    return dtTableCF;
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


        //Load danh sách bàn
        public DataTable TableList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("TableList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    DataTable dtTableCF = new DataTable();
                    //dtTableCF.Load(cmd.ExecuteReader());
                    return dtTableCF;
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

using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DAL_TableCF : DBConnect
    {
        SqlConnection conn;
        SqlDataAdapter adt;
        DataTable dt;


        public DataTable get()
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetTableCF";
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertTableCF";

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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateTableCF";

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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteTableCF";
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchTableCF";

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
                using (conn = new SqlConnection(_conn))
                {
                    conn.Open();
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.Connection = conn;
                    //cmd.CommandType = CommandType.StoredProcedure ;
                    //cmd.CommandText = "TableList";
                    //DataTable dtListCF = new DataTable();
                    //return dtListCF;
                    string Query = "TableList";
                    adt = new SqlDataAdapter(Query, _conn);
                    dt = new DataTable();
                    adt.Fill(dt);
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

        //Thông tin bàn
        public DataTable TableInfo(DTO_Bill bill)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    conn.Open();
                    string Query = "exec TableInfo @IdTable = '" + bill.IdTable + "'";
                    adt = new SqlDataAdapter(Query, _conn);
                    dt = new DataTable();
                    adt.Fill(dt);
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
    }
}

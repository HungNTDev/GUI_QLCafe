using DTO_QLCafe;
using System;
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
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetTable";
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
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertTable";
                    cmd.Parameters.AddWithValue("@NameTable", obj.NameTable);
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
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateTable ";

                    cmd.Parameters.AddWithValue("@IdTable", obj.IdTable);
                    cmd.Parameters.AddWithValue("@NameTable", obj.NameTable);
                    cmd.Parameters.AddWithValue("@statusTableCF", obj.StatusTableCF);

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
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteTable";
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

        public DataTable search(string keyword)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchTable";
                    cmd.Parameters.AddWithValue("@value", keyword);
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
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TableList";
                    conn.Open();
                    DataTable dtListCF = new DataTable();
                    dtListCF.Load(cmd.ExecuteReader());
                    return dtListCF;
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
            //    try
            //    {
            //        using (conn = new SqlConnection(_conn))
            //        {
            //            conn.Open();
            //            //string Query = "exec TableInfo @IdTable = '" + bill.IdTable + "'";
            //            //adt = new SqlDataAdapter(Query, _conn);
            //            //dt = new DataTable();
            //            //adt.Fill(dt);
            //            //return dt;
            //            //SqlCommand cmd = new SqlCommand();
            //            //cmd.Connection = conn;
            //            //cmd.CommandType = CommandType.StoredProcedure;
            //            //cmd.CommandText = "TableInfo";
            //            //cmd.Parameters.AddWithValue("IdTable", bill.idTable);
            //            //conn.Open();
            //            //DataTable dtListCF = new DataTable();
            //            //dtListCF.Load(cmd.ExecuteReader());
            //            //return dtListCF;
            //        }
            //    }
            //    finally
            //    {
            //        if (conn.State == ConnectionState.Open)
            //        {
            //            conn.Close();
            //        }
            //    }
            string Query = "exec TableInfo @IdTable = '" + bill.IdTable + "'";
            adt = new SqlDataAdapter(Query, _conn);
            dt = new DataTable();
            adt.Fill(dt);
            return dt;
        }

        public DataTable GetPagedTable(int PageIndex, int PageSize)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetPagedTable";
                    cmd.Parameters.AddWithValue("@PageIndex", PageIndex);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        Console.WriteLine("Không có dữ liệu được trả về từ proc");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public bool KiemtraTrungTenBan(string id)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "KiemTraTenBan";
                    cmd.Parameters.AddWithValue("@nameTable", id);
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

        public DataTable getIdTable(out string Next)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    using (SqlCommand cmd = new SqlCommand("GetIdTable", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter NextId = new SqlParameter("@Next", SqlDbType.NVarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(NextId);

                        // Open connection and execute query
                        conn.Open();
                        DataTable dtTableCF = new DataTable();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dtTableCF.Load(reader);
                        }

                        Next = NextId.Value.ToString();
                        return dtTableCF;
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

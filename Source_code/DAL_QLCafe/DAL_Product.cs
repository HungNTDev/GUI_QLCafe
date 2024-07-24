using DTO_QLCafe;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLCafe
{
    public class DAL_Product : DBConnect
    {
        SqlConnection conn;
        public DataTable get()
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand("GetProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    DataTable dtProduct = new DataTable();
                    dtProduct.Load(cmd.ExecuteReader());
                    return dtProduct;
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

        public DataTable getType()
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand("GetProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    DataTable dtProduct = new DataTable();
                    dtProduct.Load(cmd.ExecuteReader());
                    return dtProduct;
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
        public bool insert(DTO_Product obj)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertProduct";
                    cmd.Parameters.AddWithValue("@IdProduct", obj.IdProduct);
                    cmd.Parameters.AddWithValue("@NameProduct", obj.NameProduct);
                    cmd.Parameters.AddWithValue("@Price", obj.Price);
                    cmd.Parameters.AddWithValue("@ImageProduct", obj.ImageProduct);
                    cmd.Parameters.AddWithValue("@StatusProduct", obj.StatusProduct);
                    cmd.Parameters.AddWithValue("@IdPT", obj.IdPT);

                    conn.Open();

                    if (Convert.ToInt16(cmd.ExecuteNonQuery()) > 0)
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

        public bool update(DTO_Product obj)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateProduct";
                    cmd.Parameters.AddWithValue("@idProduct", obj.IdProduct);
                    cmd.Parameters.AddWithValue("@nameProduct", obj.NameProduct);
                    cmd.Parameters.AddWithValue("@price", obj.Price);
                    cmd.Parameters.AddWithValue("@imageProduct", obj.ImageProduct);
                    cmd.Parameters.AddWithValue("@idpt", obj.IdPT);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
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
                    cmd.CommandText = "DeleteProcduct";
                    cmd.Parameters.AddWithValue("@id", id);
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
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchProduct";
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    cmd.Parameters.AddWithValue("@column", column);
                    conn.Open();
                    DataTable dtProduct = new DataTable();
                    dtProduct.Load(cmd.ExecuteReader());
                    return dtProduct;
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

        //Danh sách sản phẩm
        public DataTable LoadMenu(DTO_Product product)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ListMenu";
                    cmd.Parameters.AddWithValue("@idPT", product.idPT);
                    conn.Open();
                    DataTable dtMenu = new DataTable();
                    dtMenu.Load(cmd.ExecuteReader());
                    return dtMenu;
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

        public DataTable LoadIDPT()
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LoadIDPT";
                    conn.Open();
                    DataTable dtIDPT = new DataTable();
                    dtIDPT.Load(cmd.ExecuteReader());
                    return dtIDPT;
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

        public DataTable ListType(string type)
        {
            try
            {
                DataTable db = new DataTable();
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ListType";
                    cmd.Parameters.AddWithValue("@IdPT", type);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(db);
                    return db;
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

        public DataTable GetPage(int PageIndex)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetProductPage";
                    cmd.Parameters.AddWithValue("@PageIndex", PageIndex);
                    cmd.Parameters.AddWithValue("@PageSize", 5);
                    cmd.Parameters.Add("@RecordCount", SqlDbType.Int);
                    cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;
                    conn.Open();
                    DataTable db = new DataTable();
                    db.Load(cmd.ExecuteReader());
                    int recordCount = Convert.ToInt32(cmd.Parameters["@RecordCount"].Value);
                    return db;
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

        public DataTable GetPagedProduct(int PageIndex, int PageSize)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetPagedProduct";
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

        public int GetTotalProductCount()
        {
            int totalProductCount = 0;
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetTotalProductCount";
                    conn.Open();
                    totalProductCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return totalProductCount;
        }
    }
}

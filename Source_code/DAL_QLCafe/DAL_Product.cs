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
                    cmd.Parameters.AddWithValue("@statusProduct", obj.StatusProduct);
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
    }
}

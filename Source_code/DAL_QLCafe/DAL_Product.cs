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
                    cmd.Parameters.AddWithValue("@IdProduct", obj.IdProduct);
                    cmd.Parameters.AddWithValue("@NameProduct", obj.NameProduct);
                    cmd.Parameters.AddWithValue("@Price", obj.Price);
                    cmd.Parameters.AddWithValue("@ImageProduct", obj.ImageProduct);
                    cmd.Parameters.AddWithValue("@StatusProduct", obj.StatusProduct);
                    cmd.Parameters.AddWithValue("@IdPT", obj.IdPT);

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
                    cmd.CommandText = "DeleteProduct";
                    cmd.Parameters.AddWithValue("@IdProduct", id);
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

    }
}

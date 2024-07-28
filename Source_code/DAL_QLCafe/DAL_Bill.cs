using DTO_QLCafe;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLCafe
{
    public class DAL_Bill : DBConnect
    {
        SqlConnection conn;
        public DataTable get()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetBill";
                    conn.Open();
                    DataTable dtBill = new DataTable();
                    dtBill.Load(cmd.ExecuteReader());
                    return dtBill;
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

        public bool insert(DTO_Bill obj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertBill";
                    cmd.Parameters.AddWithValue("@IdBill", obj.IdBill);
                    cmd.Parameters.AddWithValue("@IdTable", obj.IdTable);
                    cmd.Parameters.AddWithValue("@IdPayment", obj.IdPayment);
                    cmd.Parameters.AddWithValue("@IdStaff", obj.IdStaff);
                    cmd.Parameters.AddWithValue("@IdVoucher", obj.IdVoucher);
                    cmd.Parameters.AddWithValue("@StatusBill", obj.StatusBill);
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

        public bool update(DTO_Bill obj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateBill";
                    cmd.Parameters.AddWithValue("@IdBill", obj.IdBill);
                    cmd.Parameters.AddWithValue("@IdTable", obj.IdTable);
                    cmd.Parameters.AddWithValue("@IdPayment", obj.IdPayment);
                    cmd.Parameters.AddWithValue("@IdStaff", obj.IdStaff);
                    cmd.Parameters.AddWithValue("@IdVoucher", obj.IdVoucher);
                    cmd.Parameters.AddWithValue("@StatusBill", obj.StatusBill);
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
                { conn.Close(); }
            }
            return false;
        }

        public bool delete(string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteBill";
                    cmd.Parameters.AddWithValue("@IdBill", id);
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
                { conn.Close(); }
            }
            return false;
        }
        public DataTable search(string keyword, string column)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchBill";
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                    cmd.Parameters.AddWithValue("@column", column);
                    conn.Open();
                    DataTable dtBill = new DataTable();
                    dtBill.Load(cmd.ExecuteReader());
                    return dtBill;
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

        //Xem thông tin bill dựa trên bàn
        public DataTable BillInfo(DTO_Bill bill)
        {
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(_conn))
            //    {
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "BillInfo";
            //        cmd.Parameters.AddWithValue("@IdTable", bill.idTable);
            //        conn.Open();
            //        DataTable dtBill = new DataTable();
            //        dtBill.Load(cmd.ExecuteReader());
            //        return dtBill;
            //    }
            //}
            //finally
            //{
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        conn.Close();
            //    }
            //}

            using (SqlConnection Connection = new SqlConnection(_conn))
            {
                string Query = @"exec BillInfo @idTable = '" + bill.IdTable + "'";
                SqlDataAdapter adt = new SqlDataAdapter(Query, _conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }

        //Thêm bill
        public bool AddingBill(DTO_Bill bill)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AddingBill";
                    cmd.Parameters.AddWithValue("@IdStaff", bill.idStaff);
                    cmd.Parameters.AddWithValue("@IdTable", bill.IdTable);
                    cmd.Parameters.AddWithValue("@DateCheckIn", bill.DateCheckIn);
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

using DTO_QLCafe;
using System;
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
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LoadBill";
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

        public bool delete(string id)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "BIllDelete";
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
        public DataTable search(string keyword)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchBill";
                    cmd.Parameters.AddWithValue("@value", keyword);
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

            using (conn = new SqlConnection(_conn))
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

        public DataTable ShowVoucher()
        {
            using (conn = new SqlConnection(_conn))
            {
                string Query = @"exec ShowVoucher";
                SqlDataAdapter adt = new SqlDataAdapter(Query, _conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }

        public DataTable ShowPayment()
        {
            using (conn = new SqlConnection(_conn))
            {
                string Query = @"exec ShowPayment";
                SqlDataAdapter adt = new SqlDataAdapter(Query, _conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }

        //Thêm detail bill
        public bool AddingDetailBill(DTO_Bill Bill)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AddingDetailBill";
                    cmd.Parameters.AddWithValue("@IdTable", Bill.IdTable);

                    cmd.Parameters.AddWithValue("@IdProduct", Bill.IdProduct);
                    cmd.Parameters.AddWithValue("@Amount", Bill.Amount);
                    cmd.Parameters.AddWithValue("@TotalPrice", Bill.TotalPrice);
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

        public DataTable GetPagedBill(int PageIndex, int PageSize)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetPagedBill";
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

        public int GetTotalBillCount()
        {
            int totalBillCount = 0;
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetTotalBillCount";
                    conn.Open();
                    totalBillCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return totalBillCount;
        }

        public bool MergeBillMenu(DTO_Bill bill, int amount)
        {
            string Query = @"exec MergeBillMenu @IdTable = '" + bill.IdTable + "', @quanity = '" + bill.Amount + "', @quanityNew = '" + amount + "' ";
            SqlDataAdapter adt = new SqlDataAdapter(Query, _conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            return true;
        }

        public bool AddStatistic(DTO_Bill Bill, DTO_Voucher Voucher)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AddStatistic";
                    cmd.Parameters.AddWithValue("@IdBill", Bill.IdBill);
                    cmd.Parameters.AddWithValue("@PercentVoucher", Voucher.PercentVoucher);
                    cmd.Parameters.AddWithValue("@Total", Bill.TotalPrice);
                    cmd.Parameters.AddWithValue("@NameStaff", Bill.NameStaff);
                    cmd.Parameters.AddWithValue("@CheckIn", Bill.dateCheckIn);
                    cmd.Parameters.AddWithValue("@CheckOut", Bill.dateCheckOut);
                    cmd.Parameters.AddWithValue("@namePayment", Bill.NamePayment);
                    cmd.Parameters.AddWithValue("@NameTable", Bill.NameTable);
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

        public bool AddDetailStatistic(DTO_Bill Bill)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AddDetailStatistic";
                    cmd.Parameters.AddWithValue("@IdBill", Bill.IdBill);
                    cmd.Parameters.AddWithValue("@NameProduct", Bill.NameProduct);
                    cmd.Parameters.AddWithValue("@Amount", Bill.Amount);
                    cmd.Parameters.AddWithValue("@Price", Bill.Price);
                    cmd.Parameters.AddWithValue("@TotalPrice", Bill.totalPrice);
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

        // Danh sách thống kê
        public DataTable GetStatistic()
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetStatistic";
                    conn.Open();
                    DataTable dtStatistic = new DataTable();
                    dtStatistic.Load(cmd.ExecuteReader());
                    return dtStatistic;
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

        // Phân trang thống kê
        public DataTable GetPagedStatistic(int PageIndex, int PageSize)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetPagedStatistic";
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

        // Lấy tổng số
        public int GetTotalStatisticCount()
        {
            int totalBillCount = 0;
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetTotalStatisticCount";
                    conn.Open();
                    totalBillCount = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return totalBillCount;
        }

        // Tìm kiếm thống kê
        public DataTable SearchStatistic(string keyword)
        {
            try
            {
                using (conn = new SqlConnection(_conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchStatistic";
                    cmd.Parameters.AddWithValue("@value", keyword);
                    conn.Open();
                    DataTable dtStatistic = new DataTable();
                    dtStatistic.Load(cmd.ExecuteReader());
                    return dtStatistic;
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

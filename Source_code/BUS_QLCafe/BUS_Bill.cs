using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace BUS_QLCafe
{
    public class BUS_Bill
    {
        DAL_Bill dal = new DAL_Bill();

        public DataTable get()
        {
            return dal.get();
        }
        public bool delete(string obj)
        {
            return dal.delete(obj);
        }
        public DataTable search(string keyword)
        {
            return dal.search(keyword);
        }

        public DataTable GetPagedBill(int PageIndex, int PageSize)
        {
            return dal.GetPagedBill(PageIndex, PageSize);
        }

        public int ToTalBill()
        {
            return dal.GetTotalBillCount();
        }

        //Xem thông tin bill
        public DataTable BillInfo(DTO_Bill bill)
        {
            return dal.BillInfo(bill);
        }

        //Thêm bill
        public bool AddingBill(DTO_Bill bill)
        {
            return dal.AddingBill(bill);
        }

        public DataTable ShowVoucher()
        {
            return dal.ShowVoucher();
        }

        public DataTable ShowPayment()
        {
            return dal.ShowPayment();
        }


        //Thêm detail bill
        public bool AddingDetailBill(DTO_Bill Bill)
        {
            return dal.AddingDetailBill(Bill);
        }

        public bool MergeBillMenu(DTO_Bill bill, int amount)
        {
            return dal.MergeBillMenu(bill, amount);
        }

        public bool AddStatistic(DTO_Bill Bill, DTO_Voucher Voucher)
        {
            return dal.AddStatistic(Bill, Voucher);
        }

        public bool AddDetailStatistic(DTO_Bill Bill)
        {
            return dal.AddDetailStatistic(Bill);
        }
    }
}

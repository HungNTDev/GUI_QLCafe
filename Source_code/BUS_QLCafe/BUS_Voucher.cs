using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace BUS_QLCafe
{
    public class BUS_Voucher
    {
        DAL_Voucher dal = new DAL_Voucher();
        public int GetTotalVoucherCount()
        {
            return dal.GetTotalVoucherCount();
        }
        public DataTable GetPageVoucher(int pageIndex, int pageSize)
        {
            return dal.GetPagedVoucher(pageIndex, pageSize);
        }
        public DataTable get()
        {
            return dal.get();
        }
        public bool KiemTraVoucher(string id)
        {
            return dal.KiemTraVoucher(id);
        }
        public bool insert(DTO_Voucher obj)
        {
            return dal.insert(obj);
        }
        public bool update(DTO_Voucher obj)
        {
            return dal.update(obj);
        }
        public bool delete(string id)
        {
            return dal.delete(id);
        }
        public DataTable search(string value, int pageNumber, int pageSize, out int totalRows, out int totalPages)
        {
            // Call the DAL search method
            return dal.search(value, pageNumber, pageSize, out totalRows, out totalPages);
        }
    }
}

using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;
namespace BUS_QLCafe
{
    public class BUS_DetailBill
    {
        DAL_DetailBill dal = new DAL_DetailBill();

        public DataTable get()
        {
            return dal.get();
        }

        public bool insert(DTO_DetailBill obj)
        {
            return dal.insert(obj);
        }

        public bool update(DTO_DetailBill obj)
        {
            return dal.update(obj);
        }

        public bool delete(string obj)
        {
            return dal.delete(obj);
        }

        public DataTable search(string obj)
        {
            return dal.search(obj);
        }

        //Thêm detail bill
        public bool AddingDetailBill(DTO_DetailBill detailBill)
        {
            return dal.AddingDetailBill(detailBill);
        }

    }
}

using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;
namespace BUS_QLCafe
{
    public class BUS_Product
    {
        DAL_Product dal = new DAL_Product();

        public DataTable get()
        {
            return dal.get();
        }

        public bool insert(DTO_Product obj)
        {
            return dal.insert(obj);
        }

        public bool update(DTO_Product obj)
        {
            return dal.update(obj);
        }

        public bool delete(string obj)
        {
            return dal.delete(obj);
        }

        public DataTable search(string keyword, string column)
        {
            return dal.search(keyword, column);
        }

        //Danh sach thuc pham
        public DataTable LoadMenu(DTO_Product product)
        {
            return dal.LoadMenu(product);
        }

        public DataTable LoadIDPT()
        {
            return dal.LoadIDPT();
        }

        public DataTable ListType(string obj)
        {
            return dal.ListType(obj);
        }

        public DataTable Page(int obj)
        {
            return dal.GetPage(obj);
        }
    }
}

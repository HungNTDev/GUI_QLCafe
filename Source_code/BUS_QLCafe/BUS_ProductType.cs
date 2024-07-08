using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace BUS_QLCafe
{
    public class BUS_ProductType
    {
        DAL_ProductType dal = new DAL_ProductType();

        public DataTable get()
        {
            return dal.get();
        }

        public bool insert(DTO_ProductType obj)
        {
            return dal.insert(obj);
        }

        public bool update(DTO_ProductType obj)
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
    }
}

using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;
namespace BUS_QLCafe
{
    public class BUS_TableCF
    {
        DAL_TableCF dal = new DAL_TableCF();
        public DataTable get()
        {
            return dal.get();
        }

        public bool insert(DTO_TableCF obj)
        {
            return dal.insert(obj);
        }

        public bool update(DTO_TableCF obj) { return dal.update(obj); }

        public bool delete(DTO_TableCF obj)
        {
            return dal.delete(obj);
        }


        public DataTable search(string keyword, string column)
        {
            return dal.search(keyword, column);
        }
    }
}

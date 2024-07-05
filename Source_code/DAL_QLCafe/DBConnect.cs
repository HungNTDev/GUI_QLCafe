using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("server=CHIBAO\\SQLEXPRESS; database=QL_Cafe; integrated security=true");
    }
}

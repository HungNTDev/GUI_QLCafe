using System.Data.SqlClient;

namespace DAL_QLCafe
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data source=DESKTOP-T731SJL\\TUANHUNG; database=QL_Cafe; integrated security=true");
    }
}

using System.Configuration;

namespace DAL_QLCafe
{
    public class DBConnect
    {
        //protected SqlConnection conn = new SqlConnection("Data source=DESKTOP-QIE438C\\MAYAO; database=QL_Cafe; integrated security=true");
        protected string _conn = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
    }
}

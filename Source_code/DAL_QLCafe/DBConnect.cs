using System.Data.SqlClient;
using System.Web.Configuration;

namespace DAL_QLCafe
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data source=BLVCKHEVRT; database=QL_Cafe; integrated security=true");
        protected string _conn = WebConfigurationManager.ConnectionStrings["Data"].ConnectionString;
    }
}

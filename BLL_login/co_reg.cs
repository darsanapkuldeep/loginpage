using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DLL_login;
namespace BLL_login
{
    public class co_reg
    {
        public SqlCommand cm;
        public SqlConnection co;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public SqlConnection connect()
        {
            co = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_login;Integrated Security=True");
            co.Open();
            return co;
        }

    }
}

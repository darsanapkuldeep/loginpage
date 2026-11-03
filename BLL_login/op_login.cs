using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_login;
namespace BLL_login
{
    public class op_login
    {
        co_reg co = new co_reg();
        public void empreg(et_reg el,et_log er)
        {
            co.cm = new SqlCommand("sp_reg", co.connect());
            co.cm.CommandType = CommandType.StoredProcedure;
            co.cm.Parameters.AddWithValue("@name", el.name);
            co.cm.Parameters.AddWithValue("@phone", el.phone);
            co.cm.Parameters.AddWithValue("@email", el.email);
            co.cm.Parameters.AddWithValue("@password", el.password);
            co.cm.Parameters.AddWithValue("@emil_id", er.emil_id);
            co.cm.Parameters.AddWithValue("@pswrd", er.pswrd);
            co.cm.ExecuteNonQuery();

        }
        public bool  emplogin(et_log er)
        {
              co.cm = new SqlCommand("sp_login", co.connect());
            co.cm.CommandType = CommandType.StoredProcedure;

            co.cm.Parameters.AddWithValue("@emil_id", er.emil_id);
            co.cm.Parameters.AddWithValue("@pswrd", er.pswrd);

            object result = co.cm.ExecuteScalar();

            int count = Convert.ToInt32(result);

            return count > 0;
        }

    }

}




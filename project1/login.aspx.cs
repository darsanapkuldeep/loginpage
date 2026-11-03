using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DLL_login;
using BLL_login;

namespace project1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            et_log er = new et_log();

            er.emil_id = email;
            er.pswrd = password;

            op_login op = new op_login();

            if (op.emplogin(er))
            {
                Response.Write("<script>alert('Login Successful');</script>");
            }
            else
            {
                Response.Write("<script>alert('Invalid Email or Password');</script>");
            }
        }
    }
}
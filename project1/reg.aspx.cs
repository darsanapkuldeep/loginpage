using BLL_login;
using DLL_login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project1
{
    public partial class reg : System.Web.UI.Page
    {
        co_reg co = new co_reg();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            et_reg el = new et_reg();
            et_log er = new et_log();
            el.name = txtName.Text;
            el.phone=txtphone.Text;
            el.email = txtEmail.Text;
            el.password = txtPassword.Text;
            er.emil_id = txtEmail.Text;
            er.pswrd = txtPassword.Text;
            op_login op = new op_login();
            op.empreg(el,er);
            Response.Write("<script>alert('Registration successfull!');</script>");
            Response.Redirect("login.aspx");
        }
    }
}
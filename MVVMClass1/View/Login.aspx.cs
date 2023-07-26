using MVVMClass1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MVVMClass1.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "" && txtCorreo.Text != null)
            {
                if (txtPass.Text != null && txtPass.Text != null) {

                    ClUsuarioVM objUsuarioVM = new ClUsuarioVM();
                    int rowcount = objUsuarioVM.mtdLogin(txtCorreo.Text, txtPass.Text);

                    if (rowcount >= 1)
                    {

                        Session["Usuario"] = txtCorreo.Text;
                        Response.Redirect("~/View/Agenda.aspx");

                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(this, GetType(), "UserNotFound", "UserNotFound();", true);
                        

                    }

                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "voidpassword", "voidpassword();", true);

                }

            }
            else
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "Errorgen", "Errorgen();", true);
                

            }
            
        }

    }

}
using MVVMClass1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVVMClass1.View
{
    public partial class Agenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"].ToString() == "") {

                ScriptManager.RegisterStartupScript(this, GetType(), "HideUser", "document.getElementById('UserBox').style.display = 'none'; hideContent();", true);
                
                
            }
            else
            {

                ClUsuarioVM objUsuarioVM = new ClUsuarioVM();
                ClUsuarioEVM objUsuarioEVM = objUsuarioVM.mtdGetUserByMail(Session["Usuario"].ToString());
                lblUserName.Text = objUsuarioEVM.Nombre;
                UserPic.ImageUrl = objUsuarioEVM.Imagen;
                
                ScriptManager.RegisterStartupScript(this, GetType(), "HideSession", "document.getElementById('SesionControls').style.display = 'none';", true);
                
                if (!IsPostBack)
                {

                    ClRecordatorioVM objRecordarioVM = new ClRecordatorioVM();
                    List<ClRecordatorioEVM> listaRecordario = objRecordarioVM.mtdGetTaskByUserMail(Session["Usuario"].ToString());
                    RpRecordatorio.DataSource = listaRecordario;
                    RpRecordatorio.DataBind();


                }


            }




        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }
}
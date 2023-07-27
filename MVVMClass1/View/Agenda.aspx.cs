using MVVMClass1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

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

        protected void btnAddTask_Click(object sender, EventArgs e)
        {
            ClRecordatorioVM objRecordatorioVm = new ClRecordatorioVM();
            ClRecordatorioEVM objRecordatorioEVM = new ClRecordatorioEVM();
            objRecordatorioEVM.Recordatorio = txtNota.Text;
            
            string textoFecha = txtFecha.Text;
            DateTime FechaFormat;
            DateTime.TryParseExact(textoFecha, "yyyy-MM-ddTHH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out FechaFormat);
            string newfecha = FechaFormat.ToString("yyyy-MM-dd HH:mm:ss");
            
            objRecordatorioEVM.Fecha = newfecha;

            int res = objRecordatorioVm.mtdAddTaskByMail(Session["Usuario"].ToString() , objRecordatorioEVM);

            if (res == 1) {

                List<ClRecordatorioEVM> listaRecordario = objRecordatorioVm.mtdGetTaskByUserMail(Session["Usuario"].ToString());
                RpRecordatorio.DataSource = listaRecordario;
                RpRecordatorio.DataBind();

            }

        }
    }
}
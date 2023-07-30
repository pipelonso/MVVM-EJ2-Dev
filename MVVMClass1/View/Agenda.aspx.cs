using MVVMClass1.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
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
                
                ScriptManager.RegisterStartupScript(this, GetType(), "HideSession", "document.getElementById('SesionControls').style.display = 'none'; hideDelete(); HideEdit();", true);
                
                if (!IsPostBack)
                {
                    txtFecha.Text = DateTime.Now.ToString("yyyy-MM-ddTHH:mm");
                    ClRecordatorioVM objRecordarioVM = new ClRecordatorioVM();
                    List<ClRecordatorioEVM> listaRecordario = objRecordarioVM.mtdGetTaskByUserMail(Session["Usuario"].ToString());
                    RpRecordatorio.DataSource = listaRecordario;
                    RpRecordatorio.DataBind();

                    objRecordarioVM.mtdRemindMe(Session["Usuario"].ToString());


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

            if (textoFecha == "")
            {

                textoFecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm");

            }

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

        protected void lkbDelete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            Label lblIdRecordatorio = (Label)item.FindControl("lblidRecordatorioRP");
            int idRecordatorio = Convert.ToInt32(lblIdRecordatorio.Text);
            lblDeleteId.Text = idRecordatorio.ToString();
            ScriptManager.RegisterStartupScript(this, GetType(), "showDelete", "showDelete();", true);
        }

        protected void lkbEdit_Click(object sender, EventArgs e)
        {

            LinkButton btn = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            Label lblIdRecordatorio = (Label)item.FindControl("lblidRecordatorioRP");
            Label txtRecordatorio = (Label)item.FindControl("lblRecordatorioRP");
                        
            Label txtFecha = (Label)item.FindControl("lblFechaRP");
                        
            txtFechaEdit.Text = DateTime.Parse(txtFecha.Text).ToString("yyyy-MM-ddTHH:mm");
             
            txtNotaEdit.Text = txtRecordatorio.Text;

            int idRecordatorio = Convert.ToInt32(lblIdRecordatorio.Text);
            lblEditId.Text = idRecordatorio.ToString();
            ScriptManager.RegisterStartupScript(this, GetType(), "showEdit", "ShowEdit();", true);
        }

        protected void btnEditTask_Click(object sender, EventArgs e)
        {

            ClRecordatorioVM objRecordatorioVM = new ClRecordatorioVM();
            ClRecordatorioEVM objRecordatirioEVM = new ClRecordatorioEVM();
            objRecordatirioEVM.Recordatorio = txtNotaEdit.Text;

            string textoFecha = txtFechaEdit.Text;

            if (textoFecha == "")
            {

                textoFecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm");

            }

            DateTime FechaFormat;
            DateTime.TryParseExact(textoFecha, "yyyy-MM-ddTHH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out FechaFormat);
            string newfecha = FechaFormat.ToString("yyyy-MM-dd HH:mm:ss");

            objRecordatirioEVM.Fecha = newfecha;




            int res = objRecordatorioVM.mtdEditTaskWithId(int.Parse(lblEditId.Text), objRecordatirioEVM);

            if (res == 1)
            {

                List<ClRecordatorioEVM> listaRecordario = objRecordatorioVM.mtdGetTaskByUserMail(Session["Usuario"].ToString());
                RpRecordatorio.DataSource = listaRecordario;
                RpRecordatorio.DataBind();

            }


        }

        protected void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            ClRecordatorioVM objRecordatorioVM = new ClRecordatorioVM();
            int res = objRecordatorioVM.mtdDeleteWithId(int.Parse(lblDeleteId.Text));
            if (res == 1) {

                List<ClRecordatorioEVM> listaRecordario = objRecordatorioVM.mtdGetTaskByUserMail(Session["Usuario"].ToString());
                RpRecordatorio.DataSource = listaRecordario;
                RpRecordatorio.DataBind();

            }
        }
    }
}
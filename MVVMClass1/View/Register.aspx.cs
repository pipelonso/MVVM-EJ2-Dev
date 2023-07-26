using MVVMClass1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVVMClass1.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (txtCorreo.Text.Trim() != "")
            {

                if (txtNombres.Text.Trim() != "") {

                    if (txtPass.Text.Trim() != "" && txtPassRP.Text != "") {

                        if (txtPass.Text == txtPassRP.Text)
                        {

                            ClUsuarioVM objUsuarioVM = new ClUsuarioVM();
                            ClUsuarioEVM objUsuarioEVM = new ClUsuarioEVM();

                            objUsuarioEVM.Nombre = txtNombres.Text; ;
                            objUsuarioEVM.Correo = txtCorreo.Text;
                            objUsuarioEVM.Password = txtPass.Text;
                           
                            if (FuImagen.HasFile)
                            {

                                string imgname = FuImagen.FileName;
                                string path = Server.MapPath("~/Imagenes/UserPicks/" + imgname);
                                FuImagen.SaveAs(path);
                                objUsuarioEVM.Imagen = "~/Imagenes/UserPicks/" + imgname;

                            }
                            else
                            {

                                
                                objUsuarioEVM.Imagen = "~/Imagenes/UserPicks/Default.jpg";

                            }

                            Session["Usuario"] = txtCorreo.Text;
                            int res = objUsuarioVM.mtdRegistro(objUsuarioEVM);

                            if (res == 1)
                            {

                                
                                Response.Redirect("~/View/Agenda.aspx");


                            }
                            else
                            {

                                ScriptManager.RegisterStartupScript(this, GetType(), "Errorgen", "Errorgen();", true);

                            }

                        }

                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(this, GetType(), "voidpassword", "voidpassword();", true);

                    }

                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "voidall", "voidall();", true);

                }

            }
            else
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "voidmail", "voidmail();", true);

            }
            
        }
    }
}
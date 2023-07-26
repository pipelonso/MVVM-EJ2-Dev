using MVVMClass1.Model;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVMClass1.ViewModel
{
    public class ClUsuarioVM
    {

        public int mtdLogin(string usuario , string pass)
        {

            ClUsuarioM objUsuarioM = new ClUsuarioM();
            int rowcount = objUsuarioM.mtdLogin(usuario , pass);
            return rowcount;

        }
        
        public int mtdRegistro(ClUsuarioEVM objUsuarioEVM)
        {

            ClUsuarioM objUsuarioM = new ClUsuarioM();
            ClUsuarioEM objUsuarioEM = new ClUsuarioEM();

            objUsuarioEM.Nombre = objUsuarioEVM.Nombre;
            objUsuarioEM.Correo = objUsuarioEVM.Correo;
            objUsuarioEM.Password = objUsuarioEVM.Password;
            objUsuarioEM.Imagen = objUsuarioEVM.Imagen;

            int res = objUsuarioM.mtdRegistro(objUsuarioEM);
            return res;
        }

        public ClUsuarioEVM mtdGetUserByMail(string correo)
        {

            ClUsuarioM objUsuarioM = new ClUsuarioM();
            ClUsuarioEM objUsuarioEM = objUsuarioM.mtdGetUserByMail(correo);
            ClUsuarioEVM objNewUserEVM = new ClUsuarioEVM();

            objNewUserEVM.IdUsuario = objUsuarioEM.IdUsuario;
            objNewUserEVM.Nombre = objUsuarioEM.Nombre;
            objNewUserEVM.Correo = objUsuarioEM.Correo;
            objNewUserEVM.Password = objUsuarioEM.Password;
            objNewUserEVM.Imagen = objUsuarioEM.Imagen; 

            return objNewUserEVM;

        }


    }
}
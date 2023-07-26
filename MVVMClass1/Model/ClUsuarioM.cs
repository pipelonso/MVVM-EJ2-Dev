using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace MVVMClass1.Model
{
    public class ClUsuarioM
    {

        public int mtdLogin(string correo , string pass) 
        {
            ClProcesos objSQL = new ClProcesos();
            string consulta = "SELECT * FROM Usuario WHERE Correo = '"+correo+"' AND Password = '"+pass+"'";
            DataTable datos = objSQL.mtdConsultas(consulta);

            return datos.Rows.Count;

        }

        public int mtdRegistro(ClUsuarioEM objUsuario) {

            string insert = "INSERT INTO Usuario (Nombre , Correo , Password , Imagen) VALUES ('"+objUsuario.Nombre+"','"+objUsuario.Correo+"','"+objUsuario.Password+"','"+objUsuario.Imagen+"') ";
            ClProcesos objSQL = new ClProcesos();
            int res = objSQL.mtdComandos(insert);
            return res;
            

        }

        public ClUsuarioEM mtdGetUserByMail(string correo)
        {

            string select = "SELECT * FROM Usuario WHERE Correo = '" + correo + "'";
            ClProcesos objSQl = new ClProcesos();
            DataTable datos = objSQl.mtdConsultas(select);

            ClUsuarioEM objUsuarioEM = new ClUsuarioEM();

            objUsuarioEM.IdUsuario = int.Parse(datos.Rows[0]["IdUsuario"].ToString());
            objUsuarioEM.Nombre = datos.Rows[0]["Nombre"].ToString();
            objUsuarioEM.Correo = datos.Rows[0]["Correo"].ToString();
            objUsuarioEM.Password = datos.Rows[0]["Password"].ToString();
            objUsuarioEM.Imagen = datos.Rows[0]["Imagen"].ToString();

            return objUsuarioEM;

        }


    }
}
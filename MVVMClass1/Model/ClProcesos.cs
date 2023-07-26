using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVVMClass1.Model
{
    public class ClProcesos
    {

        public int mtdComandos(string comando)
        {

            ClConexion objCon = new ClConexion();
            using (SqlConnection con = objCon.mtdConexion()) {

                SqlCommand comand = new SqlCommand(comando, con);
                int res = comand.ExecuteNonQuery();
                objCon.mtdConexion().Close();
                return res;

            };

        }

        public DataTable mtdConsultas(string consulta) {

            ClConexion objCon = new ClConexion();

            using (SqlConnection con = objCon.mtdConexion())
            {

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                objCon.mtdConexion().Close();
                return datos;

            };


        }





    }
}
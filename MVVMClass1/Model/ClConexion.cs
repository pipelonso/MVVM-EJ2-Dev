using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace MVVMClass1.Model
{
    public class ClConexion
    {

        SqlConnection con;

        public SqlConnection mtdConexion()
        {

            con = new SqlConnection("Data Source=.;Initial Catalog=MVVMAgenda;Integrated Security=True");
            con.Open();
            return con;


        }



    }
}
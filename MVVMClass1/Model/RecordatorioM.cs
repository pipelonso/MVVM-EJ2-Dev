using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Management;

namespace MVVMClass1.Model
{
    public class RecordatorioM
    {

        public List<ClRecordatorioEM> GetAllTaskByUserMail(string correo)
        {

            string procedimiento = "getTaskByMail '" + correo + "'";
            ClProcesos objSQl = new ClProcesos();
            DataTable datos = objSQl.mtdConsultas(procedimiento);
            List<ClRecordatorioEM> listaRecordatorios = new List<ClRecordatorioEM>();   

            for (int i = 0; i < datos.Rows.Count; i++)
            {

                ClRecordatorioEM objRecordarioEM = new ClRecordatorioEM();
                objRecordarioEM.IdRecordatorio = int.Parse(datos.Rows[i]["IdRecordatorio"].ToString());
                objRecordarioEM.Recordatorio = datos.Rows[i]["Recordatorio"].ToString();
                objRecordarioEM.Fecha = datos.Rows[i]["Fecha"].ToString();
                objRecordarioEM.Llamado = int.Parse(datos.Rows[i]["Llamado"].ToString());
                listaRecordatorios.Add(objRecordarioEM);

            }

            return listaRecordatorios;

        }

        public List<List<object>> mtdGetTaskByMailNOENTITY(string correo)
        {

            string procedimiento = "getTaskByMail '" + correo + "'";
            ClProcesos objSQl = new ClProcesos();
            DataTable datos = objSQl.mtdConsultas(procedimiento);

            List<List<object>> listaRecordatorio = new List<List<object>>();

            for (int i = 0; i < datos.Rows.Count; i++)
            {

                List<object> Recordatorio = new List<object>();
                Recordatorio.Add(int.Parse(datos.Rows[i]["IdRecordatorio"].ToString()));
                Recordatorio.Add(datos.Rows[i]["Recordatorio"].ToString());
                Recordatorio.Add(datos.Rows[i]["Fecha"].ToString());
                Recordatorio.Add(int.Parse(datos.Rows[i]["Llamado"].ToString()));
                listaRecordatorio.Add(Recordatorio);

            }

            return listaRecordatorio;

        }

        public int mtdAddTaskWithMail(string correo , ClRecordatorioEM objRecordatorioEM)
        {

            ClProcesos objSQL = new ClProcesos();
            string insert = "InsertTasks '"+ correo +"' , '"+objRecordatorioEM.Recordatorio+"' , '"+objRecordatorioEM.Fecha+"'";
            int res = objSQL.mtdComandos(insert);
            return res;

        }

        public int mtdEditTaskWithId(int id, ClRecordatorioEM objRecordatorioEM)
        {

            ClProcesos objSQL = new ClProcesos();
            string edit = "EditTaskWithId "+id+" , '"+objRecordatorioEM.Recordatorio+"' , '"+objRecordatorioEM.Fecha+"'";
            int res = objSQL.mtdComandos(edit);
            return res;

        }

        public int mtdDeleteTaskWithId(int id) {

            ClProcesos objSQl = new ClProcesos();
            string edit = "DeleteTaskWithId " + id;
            int res = objSQl.mtdComandos(edit);
            return res;

        }

    }
}
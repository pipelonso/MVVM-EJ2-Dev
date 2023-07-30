using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVVMClass1.Model;
using Org.BouncyCastle.Asn1.Mozilla;

namespace MVVMClass1.ViewModel
{
    public class ClRecordatorioVM
    {

        public List<ClRecordatorioEVM> mtdGetTaskByUserMail(string correo)
        {

            RecordatorioM objRecordatorioM = new RecordatorioM();
            List<ClRecordatorioEM> listaRecordatorioEM = objRecordatorioM.GetAllTaskByUserMail(correo);

            List<ClRecordatorioEVM> listaRecordarioEVM = new List<ClRecordatorioEVM>();

            for (int i = 0; i < listaRecordatorioEM.Count; i++)
            {

                ClRecordatorioEVM objRecordarioEVM = new ClRecordatorioEVM();
                objRecordarioEVM.IdRecordatorio = listaRecordatorioEM[i].IdRecordatorio;
                objRecordarioEVM.Recordatorio = listaRecordatorioEM[i].Recordatorio;
                objRecordarioEVM.Fecha = listaRecordatorioEM[i].Fecha;
                objRecordarioEVM.Llamado = listaRecordatorioEM[i].Llamado;

                listaRecordarioEVM.Add(objRecordarioEVM);

            }

            return listaRecordarioEVM;

        }

        public List<ClRecordatorioEVM> mtdGetAllTaskByMailNOENTITY(string correo)
        {

            RecordatorioM objRecordatorioM = new RecordatorioM();
            List<List<object>> listaRecordatorio = objRecordatorioM.mtdGetTaskByMailNOENTITY(correo);

            List<ClRecordatorioEVM> listaRecordatorioEVM = new List<ClRecordatorioEVM>();

            for (int i = 0; i < listaRecordatorio.Count; i++)
            {

                ClRecordatorioEVM objRecordatorioEVM = new ClRecordatorioEVM();
                objRecordatorioEVM.IdRecordatorio = int.Parse(listaRecordatorio[i][0].ToString());
                objRecordatorioEVM.Recordatorio = listaRecordatorio[i][1].ToString();
                objRecordatorioEVM.Fecha = listaRecordatorio[i][2].ToString();
                objRecordatorioEVM.Llamado = int.Parse(listaRecordatorio[i][3].ToString());
                listaRecordatorioEVM.Add(objRecordatorioEVM);

            }

            return listaRecordatorioEVM;

        }

        public int mtdAddTaskByMail(string correo , ClRecordatorioEVM objRecordatorioEVM)
        {

            RecordatorioM objRecordatorioM = new RecordatorioM();
            ClRecordatorioEM objRecordatorioEM = new ClRecordatorioEM();
            objRecordatorioEM.Recordatorio = objRecordatorioEVM.Recordatorio;
            objRecordatorioEM.Fecha = objRecordatorioEVM.Fecha;

            int res = objRecordatorioM.mtdAddTaskWithMail(correo , objRecordatorioEM);

            return res;
        }

        public int mtdEditTaskWithId(int id , ClRecordatorioEVM objRecordatorioEVM)
        {

            RecordatorioM objRecordatorioM = new RecordatorioM();
            ClRecordatorioEM objRecordatorioEM = new ClRecordatorioEM();
            objRecordatorioEM.Recordatorio = objRecordatorioEVM.Recordatorio;
            objRecordatorioEM.Fecha = objRecordatorioEVM.Fecha;

            int res = objRecordatorioM.mtdEditTaskWithId(id , objRecordatorioEM);
            return res;
        }

        public int mtdDeleteWithId(int id)
        {
            RecordatorioM objRecordatorioM = new RecordatorioM();
            int res = objRecordatorioM.mtdDeleteTaskWithId(id);
            return res;

        }

        public void mtdRemindMe(string correo)
        {

            RecordatorioM objRecordatorioM = new RecordatorioM();
            List<ClRecordatorioEM> ListaRecordatorioEM = objRecordatorioM.mtdGetExpired(correo);

            if (ListaRecordatorioEM.Count != 0)
            {

                MailManager mailManager = new MailManager();
                mailManager.mtdMailListBuilder(correo, ListaRecordatorioEM);
                objRecordatorioM.mtdUpdateExpired(ListaRecordatorioEM);

            }


            


        }


    }
}
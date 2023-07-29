using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVMClass1.ViewModel
{
    public class MailManager
    {

        public void mtdsendMail(string nombre, string correo, string asunto, string cuerpo)
        {
            int intentosMaximos = 3;
            int intentos = 0;
            bool enviado = false;

            while (!enviado && intentos < intentosMaximos)
            {
                try
                {
                    var mailmessage = new MimeMessage();

                    mailmessage.From.Add(new MailboxAddress("Recordatorio", "danimaentertaintment@outlook.com"));
                    mailmessage.To.Add(new MailboxAddress(nombre, correo));
                    mailmessage.Subject = asunto;
                    mailmessage.Body = new TextPart()
                    {
                        Text = cuerpo
                    };

                    using (var smtpClient = new SmtpClient())
                    {
                        // Utiliza el servidor SMTP y el puerto de Microsoft 365
                        smtpClient.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);

                        // Utiliza las credenciales de tu cuenta de Microsoft 365
                        smtpClient.Authenticate("danimaentertaintment@outlook.com", "c418Alive");

                        smtpClient.Send(mailmessage);
                        smtpClient.Disconnect(true);

                        enviado = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    // Maneja la excepción o realiza algún registro de error
                    intentos++;
                }
            }

            if (!enviado)
            {
                // por si no se envía
            }
        }


    }
}
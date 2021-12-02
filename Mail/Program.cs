using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace Mail
{
    class Program
    {
        static void Main(string[] args)
        {
           try
                {
                    MailMessage message = new MailMessage();
                    var smtp = new SmtpClient();
                          
                    message.From = new MailAddress("marcelo.junior@md-online.com.br");
                    message.To.Add("marcelo.junior@md-online.com.br");
                    message.Subject = "hello World";
                    message.IsBodyHtml = false;
                    message.Body = "Hello SpaceU!! Teste de Envio de ANEXOS usando smtp em C#. \n Era o Google que tava em Frenesi com as permissões.";
                    Attachment anexo = new Attachment("C:\\Users\\Marcelo.Junior\\Desktop\\INSTALAÇÃO MDM\\teste.pdf");
                    message.Attachments.Add(anexo);
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("marcelo.junior@md-online.com.br", "trabalho308");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }
                catch (System.Exception)
                {

                    throw;
                }

           System.Environment.Exit(0);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace REST.Controllers
{
    [RoutePrefix("api/Mensagem")]
    public class MensagemController : ApiController
    {
        [AcceptVerbs("POST")]
        [Route("Enviar/{uri}")]
        public void Enviar(string uri, [FromBody] string conteudo)
        {
            Models.Mensagem mensagem = JsonConvert.DeserializeObject<Models.Mensagem>(conteudo);
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();

            try
            {               
                HttpWebRequest sendNotificationRequest = (HttpWebRequest)WebRequest.Create(uri);
                sendNotificationRequest.Method = "POST";

                string toastMessage = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                    "<wp:Notification xmlns:wp=\"WPNotification\">" +
                    "<wp:Toast>" +
                            "<wp:Text1>" + mensagem.Remetente + "</wp:Text1>" +
                            "<wp:Text2>" + mensagem.Conteudo + "</wp:Text2>" +
                            "<wp:Param>/Usuario/LerMsg.xaml?NavigatedFrom=Toast Notification</wp:Param>" +
                       "</wp:Toast> " +
                    "</wp:Notification>";

                byte[] notificationMessage = Encoding.Default.GetBytes(toastMessage);
                // Set the web request content length.
                sendNotificationRequest.ContentLength = notificationMessage.Length;
                sendNotificationRequest.ContentType = "text/xml";
                sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", "toast");
                sendNotificationRequest.Headers.Add("X-NotificationClass", "2");

                using (Stream requestStream = sendNotificationRequest.GetRequestStream())
                {
                    requestStream.Write(notificationMessage, 0, notificationMessage.Length);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

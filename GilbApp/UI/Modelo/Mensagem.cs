using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UI.Modelo
{
   public class Mensagem
    {
        public string Remetente { get; set; }
        public string Conteudo { get; set; }
        private static  HttpClient httpClient;
        static private void IniciarHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:49693/");
        }


        public static async void Enviar(string uri, Mensagem _msg)
        {
            string s = "=" + JsonConvert.SerializeObject(_msg);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            IniciarHttp();
            await httpClient.PostAsync("api/Mensagem/Enviar/"+ uri, content);
        }
    }
}

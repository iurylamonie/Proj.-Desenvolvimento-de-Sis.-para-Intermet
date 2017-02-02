using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UI.Modelo
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdAdm { get; set; }
        static private HttpClient httpClient;

        static private void IniciarHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:49693/");
        }
    }
}

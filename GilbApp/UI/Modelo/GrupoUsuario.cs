using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UI.Modelo
{
    class GrupoUsuario
    {
        public int Grupo_id { get; set; }
        public int Usuario_id { get; set; }
        static private HttpClient httpClient;

        static private void IniciarHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:49693/");
        }
    }
}

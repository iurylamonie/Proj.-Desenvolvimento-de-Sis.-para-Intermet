using Newtonsoft.Json;
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

        static public async Task<List<GrupoUsuario>> Listar(int _grupo_id)
        {
            IniciarHttp();
            var responseMessage = await httpClient.GetAsync("api/Membro/Listar/" + _grupo_id);
            string str = responseMessage.Content.ReadAsStringAsync().Result;
            var membros = JsonConvert.DeserializeObject<List<GrupoUsuario>>(str);
            return membros;
        }

        static public async void Inserir(GrupoUsuario _membro)
        {
            string s = "=" + JsonConvert.SerializeObject(_membro);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            IniciarHttp();
            await httpClient.PostAsync("api/Membro/Inserir", content);
        }

        static public async void Remover(GrupoUsuario _membro)
        {
            IniciarHttp();
            await httpClient.DeleteAsync("api/Membro/Remover/" + _membro);
        }
    }
}

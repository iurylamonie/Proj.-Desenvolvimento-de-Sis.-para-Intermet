using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UI.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uri { get; set; }
        static private HttpClient httpClient;

        static private void IniciarHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:49693/");
        }

        public static async Task<List<Usuario>> Listar()
        {
            IniciarHttp();
            var responseMessage =  await httpClient.GetAsync("api/Usuario/Listar");
            string str = responseMessage.Content.ReadAsStringAsync().Result;
            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(str);
            return usuarios;
        }

        public static async Task<string> ConsultarPorNome(string _nome)
        {
            IniciarHttp();
            var responseMessage = await httpClient.GetAsync("api/Usuario/ConsultarPornome/" + _nome);
            string str = responseMessage.Content.ReadAsStringAsync().Result;
            string strNome = JsonConvert.DeserializeObject<string>(str);
            return strNome;
        }

        public static async void Inserir(Usuario _usuario)
        {
            string s = "=" + JsonConvert.SerializeObject(_usuario);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            IniciarHttp();
            await httpClient.PostAsync("api/Usuario/Inserir", content);
        }

        public static async void AlterarUri(Usuario _usuario)
        {
            IniciarHttp();
            string s = "=" + JsonConvert.SerializeObject(_usuario);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            await httpClient.PutAsync("api/Usuario/AlterarUri/" + _usuario.Nome, content);
        }

        public static async void Deletar(string _nome)
        {
            IniciarHttp();
            await httpClient.DeleteAsync("api/Usuario/Deletar/" + _nome);
        }

        public static async void Alterar(string _antigoNome, Usuario _usuario)
        {
            IniciarHttp();
            string s = "=" + JsonConvert.SerializeObject(_usuario);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            await httpClient.PutAsync("api/Usuario/Alterar/" + _antigoNome, content);
        }

    }
}

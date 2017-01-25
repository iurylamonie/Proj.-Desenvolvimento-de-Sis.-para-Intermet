using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ModeloLoja
{
    public class Funcionario
    {
        private int id;
        private string nome, telefone, identidade, ct, observacao;
        private HttpClient httpClient
            
        public int Id { get { return id} set { id = value} }
        public int Nome { get { return nome} set { nome = value} }
        public int Telefone { get { return telefone} set { telefone = value} }
        public int Identidade { get { return identidade} set { identidade = value} }
        public int Ct { get { return ct} set { ct = value} }
        public int Observacao { get { return observacao} set { observacao = value} }
        
        private void IniciarHtttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("atualizar");
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Funcionario> Listar ()
        {
            IniciarHttp();
            var response = httpClient.GetAsync("api/Funcionario/Listar");
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(str);
            return funcionarios;
        }
        
         public static void Registrar(Funcionario _funcionario)
        {
            IniciarHttp();
            string s = "=" + JsonConvert.SerializeObject(_chamado);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            httpClient.PostAsync("api/Funcionario/Registrar", content);
        }
        
        public static void Atualizar(Funcionario _funcinario)
        {
            IniciarHttp();
             string s = "=" + JsonConvert.SerializeObject(_funcinario);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            httpClient.PutAsync("api/Funcionario/Atualizar/" + _funcinario.Id, content);
        }
        
        public static void Deletar(int _id)
        {
            IniciarHttp();
            httpClient.DeleteAsync("api/Funcionario/Deletar/" + _id);
        }
        
        public static Funcionario ConsultarPorId(int _id)
        {
            IniciarHttp();
            var response = httpClient.GetAsync("api/Funcionario/ConsultarPorId/" _id);
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var funcionario = JsonConvert.DeserializeObject<Funcionario>(str);
            return funcionario;
        }
        
        public static Funcionario ConsultarPorIdentidade(int _identidade)
        {
            IniciarHttp();
            var response = httpClient.GetAsync("api/Funcionario/ConsultarPorIdentidade/" _identidade);
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var funcionario = JsonConvert.DeserializeObject<Funcionario>(str);
            return funcionario;
        }
    }
}

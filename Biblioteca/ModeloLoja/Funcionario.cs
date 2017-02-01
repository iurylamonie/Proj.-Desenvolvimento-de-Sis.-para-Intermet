using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Net.Http;
using Newtonsoft.Json;

namespace ModeloLoja
{
    public class Funcionario
    {
        private int id;
        private string nome, telefone, identidade, ct, observacao;
        private double salario;
        private bool motorista, tecnico;
        private static HttpClient httpClient;
            
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Identidade { get { return identidade; } set { identidade = value; } }
        public string Ct { get { return ct; } set { ct = value; } }
        public string Observacao { get { return observacao; } set { observacao = value; } }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public bool Motorista
        {
            get
            {
                return motorista;
            }

            set
            {
                motorista = value;
            }
        }

        public bool Tecnico
        {
            get
            {
                return tecnico;
            }

            set
            {
                tecnico = value;
            }
        }

        private static void IniciarHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:52736/");
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
            string s = "=" + JsonConvert.SerializeObject(_funcionario);
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
            var response = httpClient.GetAsync("api/Funcionario/ConsultarPorId/" + _id);
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var funcionario = JsonConvert.DeserializeObject<Funcionario>(str);
            return funcionario;
        }
        
        public static Funcionario ConsultarPorIdentidade(int _identidade)
        {
            IniciarHttp();
            var response = httpClient.GetAsync("api/Funcionario/ConsultarPorIdentidade/" + _identidade);
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var funcionario = JsonConvert.DeserializeObject<Funcionario>(str);
            return funcionario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace ModeloLoja
{
    public class Pagamento
    {
        private int id, funcionario_id, mesReferente, anoReferente;
        private double valorPago;
        private DateTime dataPagamento;
        private static HttpClient httpClient;
        
        public int Id { get{ return id; } set { id = value; } }
        public int Funcionario_id { get{ return funcionario_id; } set { funcionario_id = value; } }
        public int MesReferente { get{ return mesReferente; } set { mesReferente = value; } }
        public int AnoReferente { get{ return anoReferente; } set { anoReferente = value; } }
        public double ValorPago { get{ return valorPago; } set { valorPago = value; } }
        public DateTime DataPagamento { get{ return dataPagamento; } set { dataPagamento = value; } }


        private static void IniciarHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:52736/");
        }
        
        public static void Registrar(Pagamento _pagamento)
        {
            IniciarHttp();
            string s = "=" + JsonConvert.SerializeObject(_pagamento);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            httpClient.PostAsync("api/Pagamento/Registrar", content);
        }
        
        public static void Alterar(Pagamento _pagamento)
        {
            IniciarHttp();
            string s = "=" + JsonConvert.SerializeObject(_pagamento);
            var content = new StringContent(s, Encoding.UTF8, "application/x-www-form-urlencoded");
            httpClient.PutAsync("api/Pagamento/Alterar/" + _pagamento.Id, content);
        }
        
         public static void Deletar(int _id)
        {
            IniciarHttp();
            httpClient.DeleteAsync("api/Pagamento/Deletar/" + _id);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Pagamento> Listar (string _nomeFuncionario, int _mesReferente, int _anoReferente)
        {
            IniciarHttp();

            var r = httpClient.GetAsync("api/Funcionario/ConsultarPorNome/" + _nomeFuncionario);
            HttpResponseMessage rma = r.Result;
            string stra = rma.Content.ReadAsStringAsync().Result;
            ModeloLoja.Funcionario fun = JsonConvert.DeserializeObject<ModeloLoja.Funcionario>(stra);

            Pagamento p = new Pagamento { Funcionario_id = fun.Id, MesReferente = _mesReferente, AnoReferente = _anoReferente };

            var response = httpClient.GetAsync("api/Pagamento/Listar/" + p );
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var pagamentos = JsonConvert.DeserializeObject<List<Pagamento>>(str);
            return pagamentos;
        }
    }
}

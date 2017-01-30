using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLoja
{
    class Pagamento
    {
        private int id, funcionario_id, mesReferente, anoReferente;
        private double valorPago;
        private datetime dataPagamento;
        private HttpClient httpClient;
        
        public int Id { get{ return id } set { id = value } }
        public int Funcionario_id { get{ return funcionario_id } set { funcionario_id = value } }
        public int MesReferente { get{ return mesReferente } set { mesReferente = value } }
        public int AnoReferente { get{ return anoReferente } set { anoReferente = value } }
        public double ValorPago { get{ return valorPago } set { valorPago = value } }
        public datetime DataPagamento { get{ return dataPagamento } set { dataPagamento = value } }
        
        private void IniciarHtttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("atualizar");
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
        public static List<Pagamento> Listar (string _nomeFuncionario)
        {
            IniciarHttp();
            var response = httpClient.GetAsync("api/Pagamento/Listar/" + _nomeFuncionario);
            HttpResponseMessage rm = response.Result;
            string str = rm.Content.ReadAsStringAsync().Result;
            var pagamentos = JsonConvert.DeserializeObject<List<Pagamento>>(str);
            return pagamentos;
        }
    }
}

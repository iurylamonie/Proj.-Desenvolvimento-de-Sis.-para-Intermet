using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace RESTLoja.Controllers
{
    [RoutePrefix("api/Pagamento")]
    public class PagamentoController : ApiController
    {
        [AcceptVerbs("POST")]
        [Route("Registrar")]
        public void Registrar([FromBody] string conteudo)
        {
            Models.Pagamento pagamento = JsonConvert.DeserializeObject<Models.Pagamento>(conteudo);
            Models.LojaDataContext dc = new Models.LojaDataContext();
            dc.Pagamentos.InsertOnSubmit(pagamento);
            dc.SubmitChanges();
        }

        [AcceptVerbs("PUT")]
        [Route("Alterar/{id}")]
        public void Alterar(int id, [FromBody] string conteudo)
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            Models.Pagamento newPagamento = JsonConvert.DeserializeObject<Models.Pagamento>(conteudo);
            Models.Pagamento oldPagamento = (from p in dc.Pagamentos
                                             where p.id == id
                                             select p).Single();
            oldPagamento = newPagamento;
            dc.SubmitChanges();
        }

        [AcceptVerbs("DELETE")]
        [Route("Deletar/{id}")]
        public void Deletar(int id)
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var r = (from p in dc.Pagamentos
                     where p.id == id
                     select p).Single();
            dc.Pagamentos.DeleteOnSubmit(r);
            dc.SubmitChanges();
        }

        [AcceptVerbs("GET")]
        [Route("Listar/{nomeFuncionario}")]
        public List<Models.Pagamento> Listar(string nomeFuncionario)
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var pagamentos = from p in dc.Pagamentos
                             where p.Funcionario.nome == nomeFuncionario
                             select p;
            return pagamentos.ToList();
        }
    }

}

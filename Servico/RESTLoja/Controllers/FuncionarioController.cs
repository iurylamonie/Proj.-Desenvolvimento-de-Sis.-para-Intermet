using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace RESTLoja.Controllers
{
    [RoutePrefix("api/Funcionario")]
    public class FuncionarioController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("Listar")]
        public List<Models.Funcionario> Listar()
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var funcionarios = from f in dc.Funcionarios
                               orderby f.nome
                               select f;
            return funcionarios.ToList();
        }

        [AcceptVerbs("POST")]
        [Route("Registrar")]
        public void Registrar([FromBody] string conteudo)
        {
            Models.Funcionario funcionario = JsonConvert.DeserializeObject<Models.Funcionario>(conteudo);
            Models.LojaDataContext dc = new Models.LojaDataContext();
            dc.Funcionarios.InsertOnSubmit(funcionario);
            dc.SubmitChanges();
        }

        [AcceptVerbs("PUT")]
        [Route("Atualizar/{id}")]
        public void Atualizar(int id, [FromBody] string conteudo)
        {
            Models.Funcionario funcionario = JsonConvert.DeserializeObject<Models.Funcionario>(conteudo);
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var r = (from f in dc.Funcionarios
                     where f.id == id
                     select f).Single();

            r.ct = funcionario.ct;
            r.id = funcionario.id;
            r.identidade = funcionario.identidade;
            r.motorista = funcionario.motorista;
            r.nome = funcionario.nome;
            r.observacao = funcionario.observacao;
            r.Pagamentos = funcionario.Pagamentos;
            r.salario = funcionario.salario;
            r.tecnico = funcionario.tecnico;
            r.telefone = funcionario.telefone;

            dc.SubmitChanges();
        }

        [AcceptVerbs("DELETE")]
        [Route("Deletar/{id}")]
        public void Deletar(int id)
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var r = (from f in dc.Funcionarios
                     where f.id == id
                     select f).Single();
            dc.Funcionarios.DeleteOnSubmit(r);
            dc.SubmitChanges();
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarPorIdentidade/{identidade}")]
        public Models.Funcionario ConsultarPorIdentidade(string identidade)
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var funcionario = (from f in dc.Funcionarios
                               where f.identidade == identidade
                               select f).Single();
            return funcionario;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarPorId/{id}")]
        public Models.Funcionario ConsultarPorId(int id)
        {
            Models.LojaDataContext dc = new Models.LojaDataContext();
            var funcionario = (from f in dc.Funcionarios
                               where f.id == id
                               select f).Single();
            return funcionario;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        //função usada para verificar se já existe alguém registrado com um nome especifico. Retorna o nome caso exista, retorna "" caso não exista
        [AcceptVerbs("GET")]
        [Route("ConsultarPorNome/{nome}")]
        public string ConsultarPorNome(string nome)
        {
            try
            {
                Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
                var r = (from u in dc.Usuarios
                         where u.nome == nome
                         select u.nome).Single();
                return r;
            }
            catch (Exception)
            {
                return "";
            }
        }

        [AcceptVerbs("POST")]
        [Route("Inserir")]
        public void Inserir([FromBody] string conteudo)
        {
            Models.Usuario usuario = JsonConvert.DeserializeObject<Models.Usuario>(conteudo);
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            dc.Usuarios.InsertOnSubmit(usuario);
            dc.SubmitChanges();
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarUri/{nome}")]
        public void AlterarUri(string nome, [FromBody] string conteudo)
        {
            Models.Usuario usuario = JsonConvert.DeserializeObject<Models.Usuario>(conteudo);
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            Models.Usuario r = (from u in dc.Usuarios
                                where u.nome == nome
                                select u).Single();
            r.uri = usuario.uri;
            dc.SubmitChanges();
        }

        [AcceptVerbs("GET")]
        [Route("Listar")]
        public List<Models.Usuario> Listar()
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            var r = from u in dc.Usuarios select u;
            return r.ToList();
        }

        [AcceptVerbs("DELETE")]
        [Route("Deletar/{nome}")]
        public void Deletar(string nome)
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            var r = (from u in dc.Usuarios
                     where u.nome == nome
                     select u).Single();
            dc.Usuarios.DeleteOnSubmit(r);
            dc.SubmitChanges();
        }

        [AcceptVerbs("PUT")]
        [Route("Alterar/{nome}")]
        public void Alterar(string nome, [FromBody] string conteudo)
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            Models.Usuario usuario = JsonConvert.DeserializeObject<Models.Usuario>(conteudo);
            var r = (from u in dc.Usuarios
                     where u.nome == nome
                     select u).Single();

            r.nome = usuario.nome;

            dc.SubmitChanges();
        }

        [AcceptVerbs("GET")]
        [Route("PuxarUsuario/{nome}")]
        public Models.Usuario PuxarUsuario(string nome)
        {
            Models.WhatsappDataContext dataContext = new Models.WhatsappDataContext();
            var r = (from u in dataContext.Usuarios
                    where u.nome == nome
                    select u).Single();
            return r;
        }
    }
}

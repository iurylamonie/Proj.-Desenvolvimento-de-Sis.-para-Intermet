using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST.Controllers
{
    [RoutePrefix("api/Grupo")]
    public class GrupoController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("Listar/{usuario_id}")]
        public List<Models.Grupo> Listar(int usuario_id)
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            List<Models.Grupo> grupos = new List<Models.Grupo>();
            List<Models.GrupoUsuario> grupoPart = (from gm in dc.GrupoUsuarios
                                                   where gm.usuario_id == usuario_id
                                                   select gm).ToList();


            foreach (var item in grupoPart)
            {
                Models.Grupo r = (from g in dc.Grupos
                                  where g.id == item.grupo_id
                                  select g).Single();
                grupos.Add(r);
            }

            return grupos;
        }

        [AcceptVerbs("GET")]
        [Route("ListarMeuGrupos/{usuario_id}")]
        public List<Models.Grupo> ListarMeuGrupos(int usuario_id)
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            List<Models.Grupo> grupos = (from g in dc.Grupos
                                         where g.idAdm == usuario_id
                                         select g).ToList();
            return grupos;
        }

        [AcceptVerbs("POST")]
        [Route("Criar")]
        public void Criar([FromBody] string conteudo)
        {
            Models.WhatsappDataContext dataContext = new Models.WhatsappDataContext();
            Models.Grupo grupo = JsonConvert.DeserializeObject<Models.Grupo>(conteudo);
            dataContext.Grupos.InsertOnSubmit(grupo);
            dataContext.SubmitChanges();
        }

        [AcceptVerbs("PUT")]
        [Route("Alterar/{id}")]
        public void Alterar(int id, [FromBody] string conteudo)
        {
            Models.WhatsappDataContext dataContext = new Models.WhatsappDataContext();
            Models.Grupo grupo = JsonConvert.DeserializeObject<Models.Grupo>(conteudo);
            Models.Grupo grupoBD = (from g in dataContext.Grupos
                                    where g.id == id
                                    select g).Single();
            grupoBD.descricao = grupo.descricao;
            dataContext.SubmitChanges();
        }

        [AcceptVerbs("DELETE")]
        [Route("Deletar/{id}")]
        public void Deletar(int id)
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            var r = (from g in dc.Grupos
                     where g.id == id
                     select g).Single();
            dc.Grupos.DeleteOnSubmit(r);
            dc.SubmitChanges();
        }
    }
}

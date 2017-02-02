using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace REST.Controllers
{
    [RoutePrefix("api/Membro")]
    public class MembroController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("Listar/{grupo_id}")]
        public List<Models.GrupoUsuario> Listar(int grupo_id)
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            var r = from m in dc.GrupoUsuarios
                    where m.grupo_id == grupo_id
                    select m;
            return r.ToList() ;
        }

        [AcceptVerbs("POST")]
        [Route("Inserir")]
        public void Inserir([FromBody] string conteudo)
        {
            Models.WhatsappDataContext dataContext = new Models.WhatsappDataContext();
            Models.GrupoUsuario novoMembro = JsonConvert.DeserializeObject<Models.GrupoUsuario>(conteudo);
            dataContext.GrupoUsuarios.InsertOnSubmit(novoMembro);
            dataContext.SubmitChanges();
        }

        [AcceptVerbs("DELETE")]
        [Route("Deletar/{membro}")]
        public void Deletar(Models.GrupoUsuario membro)
        {
            Models.WhatsappDataContext dataContext = new Models.WhatsappDataContext();
            dataContext.GrupoUsuarios.DeleteOnSubmit(membro);
            dataContext.SubmitChanges();
        }
    }
}

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
        [Route("Listar")]
        public List<Models.Grupo> Listar()
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            var r = from g in dc.Grupos select g;
            return r.ToList();
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

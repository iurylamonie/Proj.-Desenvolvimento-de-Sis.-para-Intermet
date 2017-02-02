using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servico.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("Listar")]
        public List<Models.Usuario> Listar()
        {
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            var r = from u in dc.Usuarios select u;
            return r.ToList();
        }
    }
}

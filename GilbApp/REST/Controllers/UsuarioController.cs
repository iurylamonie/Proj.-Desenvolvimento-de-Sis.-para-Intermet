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
        [AcceptVerbs("POST")]
        [Route("Inserir")]
        public void Inserir([FromBody] string conteudo)
        {
            Models.Usuario usuario = JsonConvert.DeserializeObject<Models.Usuario>(conteudo);
            Models.WhatsappDataContext dc = new Models.WhatsappDataContext();
            dc.Usuarios.InsertOnSubmit(usuario);
            dc.SubmitChanges();
        }
    }
}

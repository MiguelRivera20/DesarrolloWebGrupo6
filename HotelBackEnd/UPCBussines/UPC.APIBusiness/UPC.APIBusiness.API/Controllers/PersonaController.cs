using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBContext;
using Microsoft.AspNetCore.Authorization;
using DBEntity;

namespace UPC.Business.API.Controllers
{
    [Produces("application/json")]
    [Route("api/persona")]
    [ApiController]
    public class PersonaController : Controller
    {

        protected readonly IPersonaRepository _PersonaRepository;
        public PersonaController(IPersonaRepository PersonaRepository)
        {
            _PersonaRepository = PersonaRepository;
        }
        //<sumary>

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getNumeroAndTipoDoc")]
        public ActionResult GetPersonaPorNumeroDocYTipoDoc(int tipoDoc, string numeroDoc)
        {
            PersonaEntity per = new PersonaEntity();
            per.Co_Tipo_Doc = tipoDoc;
            per.Tx_Numero_Documento = numeroDoc;
            var ret = _PersonaRepository.GetPersona(per) ;
            return Json(ret);
        }


        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("insert")]
        public ActionResult Insert(PersonaEntity project)
        {

            var ret = _PersonaRepository.RegistroPersona(project);
            return Json(ret);
        }

        /*
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getproject")]
        public ActionResult GetProject(int id)
        {
            var ret = _ProjectRepository.GetProject(id);
            return Json(ret);
        }*/


    }
}

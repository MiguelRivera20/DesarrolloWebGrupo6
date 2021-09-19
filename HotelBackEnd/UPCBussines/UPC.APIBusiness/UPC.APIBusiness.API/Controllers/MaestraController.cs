using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBContext;
using Microsoft.AspNetCore.Authorization;

namespace UPC.Business.API.Controllers
{
    [Produces("application/json")]
    [Route("api/project")]
    public class MaestraController : Controller
    {

        protected readonly IMaestraRepository _MaestraRepository;
        public MaestraController(IMaestraRepository MaestraRepository)
        {
            _MaestraRepository = MaestraRepository;
        }
        //<sumary>

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getMaestra")]
        public ActionResult GetMaestra(string maestra)
        {

            var ret = _MaestraRepository.GetMaestro(maestra);
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

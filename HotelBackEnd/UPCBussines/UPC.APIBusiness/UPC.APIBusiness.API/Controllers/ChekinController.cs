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
    [Route("api/checkIn")]
    public class ChekinController : Controller
    {

        protected readonly IChekinRepository _IChekinRepository;
        public ChekinController(IChekinRepository chekinRepository)
        {
            _IChekinRepository = chekinRepository;
        }
        //<sumary>

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getcheckIn")]
        public ActionResult GetChekin(int coChekin, int coClient)
        {
            CheckInEntity chec = new CheckInEntity();
            chec.Co_Check_In = coChekin;
            chec.Co_Cliente = coClient;
            var ret = _IChekinRepository.GetChekin(chec);
            return Json(ret);
        }


        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("chekin")]
        public ActionResult Insert(CheckInEntity checkIn)
        {

            var ret = _IChekinRepository.ChekinPersona(checkIn);
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


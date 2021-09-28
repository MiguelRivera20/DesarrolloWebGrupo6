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
    [Route("api/reserva")]
    public class ReservaController : Controller
    {

        protected readonly IReservaRepository _ReservaRepository;
        public ReservaController(IReservaRepository ReservaRepository)
        {
            _ReservaRepository = ReservaRepository;
        }
        //<sumary>

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getReserva")]
        public ActionResult GetReserva(int coReser, int coClient)
        {
            ReservaEntity reser = new ReservaEntity();
            reser.Co_Reserva = coReser;
            reser.Co_Cliente = coClient;
            var ret = _ReservaRepository.GetReserva(reser);
            return Json(ret);
        }


        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("insert")]
        public ActionResult Insert(ReservaEntity reserva)
        {

            var ret = _ReservaRepository.ReservaPersona(reserva);
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

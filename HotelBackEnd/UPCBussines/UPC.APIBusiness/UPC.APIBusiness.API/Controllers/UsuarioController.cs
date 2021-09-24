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
    [Route("api/usuario")]
    public class UsuarioController : Controller
    {

        protected readonly IUsuarioRepository _UsuarioRepository;
        public UsuarioController(IUsuarioRepository UsuarioRepository)
        {
            _UsuarioRepository = UsuarioRepository;
        }
        //<sumary>

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listarUsuariosPorfiltro")]
        public ActionResult GetPersonaPorNumeroDocYTipoDoc(int coPerfil, string username)
        {
            UsuarioEntity usu = new UsuarioEntity();
            usu.Co_Perfil = coPerfil;
            usu.Username = username;
            var ret = _UsuarioRepository.GetUsuario(usu) ;
            return Json(ret);
        }


        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("insert")]
        public ActionResult Insert(UsuarioEntity project)
        {
            var ret = _UsuarioRepository.RegistroUsuario(project);
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

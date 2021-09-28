using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UPC.Business.API.Controllers
{
    [Produces("application/json")]
    [Route("api/project")]
    [ApiController]
    public class ProjectController : Controller
    {

        protected readonly IProjectRepository _ProjectRepository;
        public ProjectController(IProjectRepository ProjectRepository)
        {
            _ProjectRepository = ProjectRepository;
        }
        //<sumary>

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getprojects")]
        public ActionResult GetProjects()
        {

            var ret = _ProjectRepository.GetProjects();
            return Json(ret);
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getproject")]
        public ActionResult GetProject(int id)
        {
            var ret = _ProjectRepository.GetProject(id);
            return Json(ret);
        }


        [Produces("application/json")]
        
        [HttpPost]
        [Route("admin/insert")]
        public ActionResult Insert(MaestraEntity project)
        {
            

           
            return Json("");
        }

    }
}

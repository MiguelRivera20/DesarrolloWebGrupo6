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
using System;

namespace UPC.Business.API.Controllers
{
    [Produces("application/json")]
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {

        protected readonly IPersonaRepository _PersonaRepository;

        protected readonly IUsuarioRepository _UsuarioRepository;
        public UsuarioController(IUsuarioRepository UsuarioRepository, IPersonaRepository PersonaRepository)
        {
            _UsuarioRepository = UsuarioRepository;
            _PersonaRepository = PersonaRepository;
        }

        //<sumary>

        //GetUsuarioPorDocumentoPersona
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getUsuarioPorDocumentoPersona")]
        public ActionResult GetUsuarioPorDocumentoPersona(int tipoDocumento, string numeroDocumento)
        {
           
            var ret = _UsuarioRepository.GetUsuarioPorDocumentoPersona(tipoDocumento, numeroDocumento);
            return Json(ret);
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listarUsuariosPorfiltro")]
        public ActionResult GetPersonaPorNumeroDocYTipoDoc(int coPerfil, string username)
        {
            UsuarioEntity usu = new UsuarioEntity();
            usu.Co_Perfil = coPerfil;
            usu.Tx_Username = username;
            var ret = _UsuarioRepository.GetUsuario(usu) ;
            return Json(ret);
        }


        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("insert")]
        public ActionResult Insert(UsuarioEntityRequest prmRequest)
        {




            UsuarioEntity usuario = new UsuarioEntity();
            usuario.Co_Usuario = prmRequest.Co_Usuario;
            usuario.Co_Persona = prmRequest.Co_Persona;
            usuario.Co_Perfil = Int32.Parse(prmRequest.Co_Perfil);
           
            usuario.Tx_Username = prmRequest.Tx_Username;
            usuario.Co_Situacion = Int32.Parse(prmRequest.Co_Situacion);

            if (prmRequest.Persona != null)
            {
                usuario.Persona = new PersonaEntity();
                usuario.Persona.Co_Persona = prmRequest.Persona.Co_Persona;
            //    usuario.Persona.Co_Tipo_Persona = Int32.Parse(prmRequest.Persona.Co_Tipo_Persona);
                usuario.Persona.Co_Tipo_Doc = Int32.Parse(prmRequest.Persona.Co_Tipo_Doc);
                usuario.Persona.Tx_Numero_Documento = prmRequest.Persona.Tx_Numero_Documento;
                usuario.Persona.Tx_Nombre_Completo = prmRequest.Persona.Tx_Nombre_Completo;
                usuario.Persona.Tx_Correo = prmRequest.Persona.Tx_Correo;
                usuario.Persona.Tx_Telefono = prmRequest.Persona.Tx_Telefono;
                usuario.Persona.Tx_Direccion = prmRequest.Persona.Tx_Direccion;
                //  usuario.Persona.Fe_Naciemiento = prmRequest.Persona.Fe_Naciemiento;
                usuario.Persona.Co_Genero = Int32.Parse(prmRequest.Persona.Co_Genero);


                PersonaEntity per = new PersonaEntity();
                per.Co_Tipo_Doc = Int32.Parse(prmRequest.Persona.Co_Tipo_Doc);
                per.Tx_Numero_Documento = prmRequest.Persona.Tx_Numero_Documento;
                BaseResponse personaResponse = _PersonaRepository.GetPersona(per);

                if (personaResponse.isSuccess && personaResponse.errorCode == "0000" && personaResponse.data != null)
                {
                    PersonaEntity persona =(PersonaEntity) personaResponse.data;
                    usuario.Co_Persona = persona.Co_Persona;
                    usuario.Persona.Co_Persona = persona.Co_Persona;
                } else
                {
                    // No se obtuvo ningun dato
                    BaseResponse registroPersonaResponse = _PersonaRepository.RegistroPersona(usuario.Persona);
                    if (registroPersonaResponse.isSuccess && registroPersonaResponse.errorCode == "0000" && registroPersonaResponse.data != null)
                    {
                        usuario.Co_Persona = (int)registroPersonaResponse.data;
                        usuario.Persona.Co_Persona = (int) registroPersonaResponse.data;
                    } else
                    {
                        //ocurrio un error al insertar la persona

                    }
                }


               
            }


            var ret = _UsuarioRepository.RegistroUsuario(usuario);


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application;
using Domain;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace WebService.Controllers
{
    public class UsuarioController : ApiController
    {

        public UsuarioApplication usuarioApplication;

        public UsuarioController()
        {
            usuarioApplication = new UsuarioApplication();
        }

        [HttpPost]
        public bool AddUsuario(Usuario usuario)
        {   
            return usuarioApplication.AddUsuario(usuario);
        }

        [HttpGet]
        public bool ValidarUsuario(Usuario usuario)
        {
            return usuarioApplication.ValidarSenha(usuario);
        }

        //[HttpGet]
        //public Usuario GetUsuario(Usuario usuario)
        //{
        //    return usuarioApplication.GetUsuario(usuario);
       // }


    }
}

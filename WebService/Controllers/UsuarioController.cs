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
using WebService.Models;

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
        public bool AddUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Login = usuarioDTO.Login,
                Email = usuarioDTO.Email,
                Senha = usuarioDTO.Senha
            };

            
            return usuarioApplication.AddUsuario(usuario);
        }

        [HttpGet]
        public bool ValidarUsuario(string usuario, string senha)
        {
            Usuario usuarioConsulta = new Usuario
            {
                Nome = "Juninho",
                Login = usuario,
                Email = "juninho_play@fodasse.com",
                Senha =  senha
            };
            return usuarioApplication.ValidarSenha(usuarioConsulta);
        }

        //[HttpGet]
        //public Usuario GetUsuario(Usuario usuario)
        //{
        //    return usuarioApplication.GetUsuario(usuario);
       // }


    }
}

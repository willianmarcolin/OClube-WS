using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Domain;
using MongoDB.Driver;

namespace Application
{
    public class UsuarioApplication
    {
        private UsuarioRepository dbUser;

        public UsuarioApplication()
        {
            dbUser = new UsuarioRepository();
        }

        public Boolean ValidarSenha(Usuario usuario)
        {
            Usuario consulta;

            try
            {
                consulta = dbUser.ConsultaUsuario(usuario);
            }
            catch (Exception)
            {
                return false;
            }

            if (usuario.Senha == consulta.Senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario GetUsuario(Usuario usuario)
        {
            try
            {
                return dbUser.ConsultaUsuario(usuario);
            }
            catch (Exception)
            {
                Usuario vazio = new Usuario();
                return vazio;
            }
        }

        public Boolean AddUsuario(Usuario usuario)
        {
            try
            {
                Usuario consultaExiste;
                consultaExiste = dbUser.ConsultaUsuario(usuario);

                if (consultaExiste.Login == usuario.Login)
                {
                    return false;
                }
                else
                {
                    dbUser.AddUsuario(usuario);
                    return true;
                }
            }

            catch (Exception)
            {
                return false;
            }

        }

        //public Boolean CastID(Usuario usuario)
       // {

        //    Usuario consulta;
        //    consulta = dbUser.ConsultaUsuario(usuario);

        //    string ID;
        //    ID = consulta._id.ToString();

        //    consulta._id = ID;

       //     return true;
       // }

    }
}

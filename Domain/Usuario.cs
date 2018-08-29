using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace Domain
{
    public class Usuario
    {
        public ObjectId _id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int TipoUsuario { get; set; }
        //public DateTime DataNascimento { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class Usuario
    {

        public int IdUsuario { get; set; }
        private static int _ultimoId;
        public string NombreUser { get; set; }
        public string ApellidoUser { get; set; }
        public string EmailUser { get; set; }
        public string PasswordUser { get; set; }


        public Usuario(int IdUsuario, string nombreUser, string apellidoUser, string emailUser, string passwordUser)
        {
            IdUsuario = _ultimoId++;
            NombreUser = nombreUser;
            ApellidoUser = apellidoUser;
            EmailUser = emailUser;
            PasswordUser = passwordUser;
        }

    }
}
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
        public string Nombre { get; set; }

        private static int _ultimoId;

        // sobrecargad de metodos

        public Usuario(string nombre)
        {
            IdUsuario = _ultimoId++;
            Nombre = nombre;
        }

    }
}

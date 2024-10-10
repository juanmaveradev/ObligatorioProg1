using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;

namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        public Subasta(
            int idPublicacion,
            string nombrePublicacion,
            DateTime fechaPublicacion,
            EnumEstadoPublicacion estadoPublicacion
            ) : base(idPublicacion, nombrePublicacion, fechaPublicacion, estadoPublicacion)
        {



        }

    }
}
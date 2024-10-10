using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;

namespace Dominio.Entidades
{
    public abstract class Publicacion
    {
        public int IdPublicacion { get; set; }
        private static int _ultimoIdPublicacion;

        public string NombrePublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public EnumEstadoPublicacion EstadoPublicacion { get; set; }

        public Publicacion(
            int idPublicacion,
            string nombrePublicacion,
            DateTime fechaPublicacion,
            EnumEstadoPublicacion estadoPublicacion
            )
        {
            IdPublicacion = ++_ultimoIdPublicacion;
            NombrePublicacion = nombrePublicacion;
            FechaPublicacion = fechaPublicacion;
            EstadoPublicacion = estadoPublicacion;
        }


        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $" ----> ID: {IdPublicacion} <-----\n";
            respuesta += $" Nombre y Apellido: {NombrePublicacion}\n";
            respuesta += $" Fecha: {FechaPublicacion} \n";
            respuesta += $" Estado: {EstadoPublicacion} \n";
            respuesta += $"------------------------------";

            return respuesta;
        }

    }
}
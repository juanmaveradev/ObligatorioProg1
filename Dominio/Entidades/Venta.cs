using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;

namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {

        public bool OfertaRelampago { get; set; }

        public Venta(
            int idPublicacion,
            string nombrePublicacion,
            DateTime fechaPublicacion,
            EnumEstadoPublicacion estadoPublicacion,

            bool ofertaRelampago
            ) : base(idPublicacion, nombrePublicacion, fechaPublicacion, estadoPublicacion)
        {


            OfertaRelampago = ofertaRelampago;

        }


        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $" ----> ID: {IdPublicacion} <-----\n";
            respuesta += $" Nombre : {NombrePublicacion}\n";
            respuesta += $" Fecha: {FechaPublicacion} \n";
            respuesta += $" Estadi: {EstadoPublicacion} \n";
            respuesta += $" Oferta Relampago: {OfertaRelampago} \n ";
            respuesta += $"------------------------------";

            return respuesta;
        }


    }
}
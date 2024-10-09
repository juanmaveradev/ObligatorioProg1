using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio.Entidades
{
    public class Articulo: IValidable
    {

        public int IdArticulo { get; set; }
        private static int _ultimoIdArticulo;

        public string NombreArt { get; set; }
        public string CategoriaArt { get; set; }
        public int PrecioVentaArt {  get; set; }


        public Articulo(string nombreArt, string categoriaArt, int precioVentaArt)
        {
            IdArticulo = _ultimoIdArticulo++;
            NombreArt = nombreArt;
            CategoriaArt = categoriaArt;
            PrecioVentaArt = precioVentaArt;
        }

        public void Validar()
        {

        }

        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $"\n------------------------------\n";
            respuesta += $" Articulo: {IdArticulo}\n";
            respuesta += $" Nombre: {NombreArt} \n";
            respuesta += $" Categoria: {CategoriaArt} \n";
            respuesta += $" Precio de Venta: {PrecioVentaArt} \n ";
            respuesta += $"------------------------------";

            return respuesta;
        }

    }
}

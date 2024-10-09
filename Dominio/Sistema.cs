

using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {

        // -----------  Listas & Propiedades -----------

        private List<Articulo> _articulos = [];
        public List<Articulo> Articulos
        {
            get { return _articulos; }
        }



        public void AgregarArticulo(Articulo unArt)
        {
            if (unArt == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            if (_articulos.Contains(unArt))
            {
                throw new Exception($"El Articulo con el nombre {unArt.NombreArt} ya existe");
            }
            unArt.Validar();
            _articulos.Add(unArt);
        }

        public Articulo ObtenerArticulo(string nombre)
        {
            foreach (Articulo item in _articulos)
            {
                if (item.NombreArt == nombre)
                {
                    return item;
                }
            }
            return null;
        }





        public List<Articulo> ListarArticulosPorCategoria(string categoria)
        {
            List<Articulo> aux = [];
            foreach (Articulo item in _articulos)
            {
                if (categoria == item.CategoriaArt)
                {
                    aux.Add(item);
                }
            }
            return aux;
        }

    }
}

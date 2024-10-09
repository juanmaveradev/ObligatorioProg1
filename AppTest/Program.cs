using Dominio;
using Dominio.Entidades;

namespace AppTest
{


    internal class Program
    {

        static Sistema _sistema = new Sistema();

        static void Main(string[] args)
        {

            int opcion = 0;
            do
            {
                Console.WriteLine("\n\n            --------\n            | Menu |\n            --------\n\n");
                opcion = PedirNumero(
                    "----- Ingrese la opción -----\n\n" +
                    " 1 -> Precargar Datos\n" +
                    " 2 -> Listar Clientes\n" +
                    " 3 -> Alta de Articulo\n" +
                    " 4 -> Listar Articulos por Categoria\n" +
                    " 5 -> Listar Publicaciones por Fecha\n" +
                    " 0 -> Salir\n\n");
                switch (opcion)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        AgregarArticulo();
                        break;
                    case 4:
                        ListarArticuloPorCategoria();
                        break;
                    case 5:

                        break;

                    default:
                        break;
                }
            }
            while (opcion != 0);
        }



        private static void AgregarArticulo()
        {
            try
            {
                Console.WriteLine("----- Ingrese los siguientes datos -----\n\n");
                string nombre = PedirString("  Nombre:");
                string categoria = PedirString("  Categoria:");
                int precio = PedirNumero("  Precio Venta:");


                Articulo unArt = new Articulo(nombre, categoria, precio);

                _sistema.AgregarArticulo(unArt);
                Console.WriteLine("\n\n---------------------------------------------------");
                Console.WriteLine("------> Articulo ingresado correctamente!!! <------");
                Console.WriteLine("---------------------------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ListarArticuloPorCategoria()
        {
            Console.WriteLine("----- Ingrese la categoria a filtrar -----\n\n");
            string categoria = PedirString(" Categoria: ");

            List<Articulo> ListaAuxArt = _sistema.ListarArticulosPorCategoria(categoria);

            foreach (Articulo articulo in ListaAuxArt)
            {
                Console.WriteLine(articulo);
            }

        }


        private static string PedirString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        private static int PedirNumero(string mensaje)
        {
            int numero = 0;
            bool seguir = false;
            do
            {
                try
                {
                    Console.WriteLine(mensaje);
                    numero = int.Parse(Console.ReadLine());
                    seguir = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo debe ingresar numeros.");
                    seguir = true;
                }

            } while (seguir);
            return numero;
        }

    

    }
}

    

    

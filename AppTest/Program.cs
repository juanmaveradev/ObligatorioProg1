using Dominio;
using Dominio.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppTest
{


    internal class Program
    {

        static Sistema _sistema = new();

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
                        PrecargarDatos();
                        break;
                    case 2:
                        ListarCliente();
                        break;
                    case 3:
                        AgregarArticulo();
                        break;
                    case 4:
                        ListarArticuloPorCategoria();
                        break;
                    case 5:
                        ListarPublicacionesPorFechas();
                        break;

                    default:
                        break;
                }
            }
            while (opcion != 0);
        }



        private static void PrecargarDatos()
        {
            try
            {
                _sistema.PrecargarDatos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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

            if (_sistema.ListarArticulosPorCategoria(categoria).Count == 0)
            {
                Console.WriteLine("\n ---->   NO EXISTEN ARTICULOS CON LA CATEGORIA INGRESADA");
            }


            foreach (Articulo articulo in ListaAuxArt)
            {
                Console.WriteLine(articulo);
            }

        }

        private static void ListarPublicacionesPorFechas()
        {
            Console.WriteLine("----- Ingrese el rango de fechas para filtrar las publicaciones -----\n");

            DateTime fechaInicio = PedirFecha("Fecha de inicio (yyyy-MM-dd): ");
            DateTime fechaFin = PedirFecha("Fecha de fin (yyyy-MM-dd): ");

            List<Publicacion> publicacionesFiltradas = _sistema.ListarPublicacionesPorFecha(fechaInicio, fechaFin);

            if (publicacionesFiltradas.Count == 0)
            {
                Console.WriteLine("\n--->   NO EXISTEN PUBLICACION EN EL RANGO DE FECHAS INGRESADO\n");
            }
            else
            {
                foreach (Publicacion publicacion in publicacionesFiltradas)
                {
                    Console.WriteLine(publicacion);
                }
            }
        }

        private static DateTime PedirFecha(string mensaje)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();
            DateTime fecha;

            while (!DateTime.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fecha))
            {
                Console.WriteLine("Formato de fecha inválido. Intente nuevamente.");
                Console.Write(mensaje);
                input = Console.ReadLine();
            }

            return fecha;
        }




        private static void ListarCliente()
        {

            if (_sistema.Clientes.Count == 0)
            {
                Console.WriteLine("\n ---->    NO EXISTEN CLIENTES EN EL SISTEMA");
            }

            foreach (Cliente item in _sistema.Clientes)
            {
                Console.WriteLine(item);
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
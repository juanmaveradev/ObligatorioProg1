using Dominio.Entidades;
using System.Linq;

namespace Dominio
{
    public class Sistema
    {

        public enum EnumEstadoPublicacion
        {
            Abierta = 0,
            Cerrada = 1,
            Cancelada = 2,
        }


        // -----------  Listas & Propiedades -----------

        private List<Articulo> _articulos = [];
        public List<Articulo> Articulos
        {
            get { return _articulos; }
        }

        private int _ultimoIdUsuario = 0;

        private List<Cliente> _clientes = [];
        public List<Cliente> Clientes
        {
            get { return _clientes; }
        }

        private List<Administrador> _administradores = [];
        public List<Administrador> Administradores
        {
            get { return _administradores; }
        }

        private List<Venta> _ventas = [];
        public List<Venta> Ventas
        {
            get { return _ventas; }
        }

        private List<Publicacion> _publicaciones = [];

        // ----------- Precarga de Datos --------------

        public void PrecargarDatos()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------\n");
            PrecargarClientes();
            Console.WriteLine("-------------------------------------------------------------------------------------\n");
            PrecargarAdministradores();
            Console.WriteLine("-------------------------------------------------------------------------------------\n");
            PrecargarArticulos();
            Console.WriteLine("-------------------------------------------------------------------------------------\n");
            PrecargarVentas();
            Console.WriteLine("-------------------------------------------------------------------------------------\n");
        }

        private void PrecargarClientes()
        {
            Cliente UnCliente = null;

            UnCliente = new Cliente(0, "Pedro", "Martinez", "pedrito@gmail.com", "contraseñaDificil", 4321);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Laura", "Gonzalez", "laura.g@gmail.com", "claveSegura123", 1234);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Juan", "Perez", "juan.perez@hotmail.com", "miClaveSecreta", 5678);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Ana", "Lopez", "ana.lopez@yahoo.com", "anaPassword", 9012);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Carlos", "Ramirez", "carlos.ramirez@gmail.com", "carRam2024", 3456);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Sofia", "Fernandez", "sofiaf@outlook.com", "claveSofia_10", 7890);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Diego", "Suarez", "diego.suarez@gmail.com", "passDiego123", 2468);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Marta", "Rodriguez", "marta_rod@hotmail.com", "martaSecure", 1357);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Luis", "Gutierrez", "luis.gutierrez@gmail.com", "luisPass2024", 9753);
            AgregarCliente(UnCliente);

            UnCliente = new Cliente(0, "Valeria", "Vargas", "valeria_v@outlook.com", "valeriaClave", 8642);
            AgregarCliente(UnCliente);

        }

        private void PrecargarAdministradores()
        {
            Administrador UnAdministrador = null;

            UnAdministrador = new Administrador(0, "Luis", "Martinez", "luismartinez@gmail.com", "adminClave123");
            AgregarAdministrador(UnAdministrador);

            UnAdministrador = new Administrador(0, "Elena", "Gonzalez", "elenagonzalez@gmail.com", "adminClave456");
            AgregarAdministrador(UnAdministrador);
        }

        private void PrecargarArticulos()
        {
            Articulo UnArticulo = null;

            UnArticulo = new Articulo("Monitor 24 pulgadas", "Electrónica", 250);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Teclado Mecánico", "Electrónica", 120);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Mouse Inalámbrico", "Electrónica", 60);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Impresora Multifuncional", "Oficina", 180);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Silla Ergonómica", "Muebles", 300);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Escritorio de Madera", "Muebles", 450);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Laptop Gamer", "Electrónica", 1500);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Auriculares Bluetooth", "Electrónica", 80);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Cámara Digital", "Fotografía", 600);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Parlante Portátil", "Electrónica", 90);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Smartphone 128GB", "Electrónica", 900);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Tablet 10 pulgadas", "Electrónica", 400);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Disco Duro Externo 1TB", "Almacenamiento", 100);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("USB 64GB", "Almacenamiento", 25);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Lámpara de Escritorio", "Iluminación", 40);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Reloj Inteligente", "Electrónica", 200);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Proyector LED", "Electrónica", 350);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Cafetera Automática", "Cocina", 120);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Microondas", "Cocina", 180);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Licuadora", "Cocina", 80);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Heladera", "Electrodomésticos", 700);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Aspiradora", "Electrodomésticos", 250);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Televisor 50 pulgadas", "Electrónica", 800);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Barra de Sonido", "Electrónica", 150);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Consola de Videojuegos", "Juguetes", 500);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Cámara de Seguridad", "Electrónica", 300);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Ventilador de Pie", "Climatización", 120);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Calefactor Eléctrico", "Climatización", 200);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Plancha de Ropa", "Electrodomésticos", 80);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Aire Acondicionado", "Climatización", 1000);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Purificador de Aire", "Climatización", 350);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Monitor 27 pulgadas", "Electrónica", 300);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Teclado Inalámbrico", "Electrónica", 70);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Cámara Web", "Electrónica", 150);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Router Wi-Fi", "Electrónica", 200);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Disco SSD 500GB", "Almacenamiento", 180);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Cable HDMI", "Accesorios", 20);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Soporte de Monitor", "Muebles", 50);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Tijeras", "Papelería", 10);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Mouse Pad", "Accesorios", 15);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Cargador Inalámbrico", "Electrónica", 40);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Batería Externa 10,000mAh", "Accesorios", 60);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Silla Gamer", "Muebles", 500);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Mesa para TV", "Muebles", 250);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Micrófono USB", "Electrónica", 180);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Caja de Herramientas", "Herramientas", 90);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Taladro Eléctrico", "Herramientas", 150);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Set de Llaves Inglesas", "Herramientas", 70);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Martillo", "Herramientas", 32);
            AgregarArticulo(UnArticulo);

            UnArticulo = new Articulo("Taladro", "Herramientas", 432);
            AgregarArticulo(UnArticulo);
        }

        private void PrecargarVentas()
        {
            Venta UnaVenta = null;

            UnaVenta = new Venta(0, "Venta de Monitor", new DateTime(2024, 1, 15), EnumEstadoPublicacion.Abierta, true);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Teclado", new DateTime(2024, 2, 10), EnumEstadoPublicacion.Abierta, false);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Mouse", new DateTime(2024, 3, 5), EnumEstadoPublicacion.Abierta, false);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Silla Ergonómica", new DateTime(2024, 4, 20), EnumEstadoPublicacion.Abierta, true);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Laptop Gamer", new DateTime(2024, 5, 12), EnumEstadoPublicacion.Abierta, true);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Auriculares Bluetooth", new DateTime(2024, 6, 18), EnumEstadoPublicacion.Abierta, false);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Televisor", new DateTime(2024, 7, 25), EnumEstadoPublicacion.Abierta, true);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Tablet", new DateTime(2024, 8, 30), EnumEstadoPublicacion.Abierta, false);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Consola de Videojuegos", new DateTime(2024, 9, 15), EnumEstadoPublicacion.Abierta, true);
            AgregarVenta(UnaVenta);

            UnaVenta = new Venta(0, "Venta de Cámara de Seguridad", new DateTime(2024, 10, 10), EnumEstadoPublicacion.Abierta, false);
            AgregarVenta(UnaVenta);
        }

        public void AgregarVenta(Venta venta)
        {
            if (venta == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            if (_ventas.Contains(venta))
            {
                throw new Exception($"La venta con el ID {venta.IdPublicacion} ya existe");
            }

            _ventas.Add(venta);
            _publicaciones.Add(venta);
            Console.WriteLine($"---> Publicacion [Tipo Venta]: {venta.IdPublicacion} cargado correctamente! <---");
        }

        public void AgregarAdministrador(Administrador administrador)
        {
            if (administrador == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            if (_administradores.Contains(administrador))
            {
                throw new Exception($"El Cliente con el ID {administrador.IdUsuario} ya existe");
            }

            administrador.IdUsuario = ++_ultimoIdUsuario;
            _administradores.Add(administrador);
            Console.WriteLine($"---> Usuario [Tipo Administrador]: {administrador.IdUsuario} cargado correctamente! <---");
        }

        public void AgregarCliente(Cliente cliente)
        {

            if (cliente == null)
            {
                throw new Exception("No se recibieron los valores");
            }
          

            cliente.IdUsuario = ++_ultimoIdUsuario;
            _clientes.Add(cliente);
            Console.WriteLine($"---> Usuario [Tipo Cliente]: {cliente.IdUsuario} cargado correctamente! <---");
        }

        public void AgregarArticulo(Articulo articulo)
        {
            if (articulo == null)
            {
                throw new Exception("No se recibieron los valores");
            }
            if (_articulos.Contains(articulo))
            {
                throw new Exception($"El Articulo con el ID {articulo.IdArticulo} ya existe");
            }


            _articulos.Add(articulo);
            Console.WriteLine($"---> Articulo: {articulo.IdArticulo} cargado correctamente! <---");
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

        public List<Publicacion> ListarPublicacionesPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Publicacion> AuxPublicacionesFiltradas = [];

            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.FechaPublicacion >= fechaInicio && publicacion.FechaPublicacion <= fechaFin)
                {
                    AuxPublicacionesFiltradas.Add(publicacion);
                }
            }

            return AuxPublicacionesFiltradas;
        }
    }

}

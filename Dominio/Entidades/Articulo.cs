using Dominio.Interfaces;

public class Articulo : IValidable
{
    public int IdArticulo { get; set; } // Ahora 'private set' para que no se pueda modificar desde fuera
    private static int _ultimoIdArticulo = 0; // Inicializa en 0 o el valor que consideres inicial.

    public string NombreArt { get; set; }
    public string CategoriaArt { get; set; }
    public int PrecioVentaArt { get; set; }

    public Articulo(string nombreArt, string categoriaArt, int precioVentaArt)
    {
        IdArticulo = ++_ultimoIdArticulo; // Incrementa y asigna el ID autoincremental
        NombreArt = nombreArt;
        CategoriaArt = categoriaArt;
        PrecioVentaArt = precioVentaArt;
    }

    public void Validar()
    {
        // Lógica de validación si es necesario
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
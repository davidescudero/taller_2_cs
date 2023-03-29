
namespace Pasteles
{
    class Ingrediente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public Ingrediente(string nombre, int cantidad, int precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
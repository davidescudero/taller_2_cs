using Pasteles;

namespace Pasteles
{
    class ProgramPrincipal
    {
        static void Main(string[] args)
        {
            Ingrediente azucar = new Ingrediente("Azucar", 1, 100);
            Ingrediente harina = new Ingrediente("Harina", 2, 200);
            Ingrediente huevo = new Ingrediente("Huevo", 10, 300);
            Ingrediente leche = new Ingrediente("Leche", 1, 400);
            Ingrediente vainilla = new Ingrediente("Vainilla", 1, 500);
            Ingrediente fresas = new Ingrediente("Fresa", 10, 10000);
            Ingrediente mantequilla = new Ingrediente("Mantequilla", 1, 700);
            Ingrediente crema = new Ingrediente("Crema", 1, 800);

            Pastel obj_pastel = new Pastel("Pastel de fresas con crema", 1);
            obj_pastel.AgregarIngrediente(azucar);
            obj_pastel.AgregarIngrediente(harina);
            obj_pastel.AgregarIngrediente(huevo);
            obj_pastel.AgregarIngrediente(leche);
            obj_pastel.AgregarIngrediente(vainilla);
            obj_pastel.AgregarIngrediente(fresas);
            obj_pastel.AgregarIngrediente(mantequilla);
            obj_pastel.AgregarIngrediente(crema);

            Console.WriteLine("\n");
            Console.WriteLine("Para hacer el  " +obj_pastel.Nombre+"  se usaron "+ obj_pastel.CantidadIngredientes() + " ingredientes , que fueron : ");
            Console.WriteLine("\n");
            Console.WriteLine(obj_pastel.ListarIngredientes());
            Console.WriteLine();
            Console.WriteLine("Costo del pastel");
            Console.WriteLine(obj_pastel.CalcularCosto());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
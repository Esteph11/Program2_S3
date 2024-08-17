
namespace EjercicioPolimorfismo
{
    public class Mascota
    {
            public string Dueño { get; set; }

            public string Tipo { get; set; }

            public double Precio { get; set; }

            public void Vendida()
            {
                Console.WriteLine($"{Tipo} ha sido comprado por el precio de L{Precio}");
                Console.WriteLine($"Su nuevo dueño: {Dueño}");
                Console.WriteLine();
            }
    }
}

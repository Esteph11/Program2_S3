
namespace EjercicioPolimorfismo
{
    public class Informacion
    {
        public string TipoMascota { get; set; }

        public string Raza { get; set; }

        public string Color { get; set; }

        public double Edad { get; set; }

        public double Precio { get; set; }

        public void Vendida()
        {
            Console.WriteLine($"Mascota: {TipoMascota} de {Raza}, de color {Color}, tiene una edad {Color}, ha sido comprado por el precio de L{Precio}");
        }
        public void Vendida(string Dueño)
        {
            Console.WriteLine($"La Mascota: {TipoMascota} ha sido vendida a su dueño {Dueño}");
        }
    }
}

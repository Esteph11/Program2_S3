
namespace EjercicioPolimorfismo
{
    public class Felino : Informacion
    {
        public Felino(string TipoMascota)
        {
            this.TipoMascota = TipoMascota;
        }

        public Felino(string TipoMascota, double Precio)
        {
            this.TipoMascota = TipoMascota;
            this.Precio = Precio;
        }
    }
}

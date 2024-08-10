
namespace EjercicioPolimorfismo
{
    public class Canino : Informacion
    {
        public Canino() { }

        public Canino(string TipoMascota)
        {
            this.TipoMascota = TipoMascota;
        }

        public Canino(string TipoMascota, double Precio)
        {
            this.TipoMascota = TipoMascota;
            this.Precio = Precio;
        }
    }
}
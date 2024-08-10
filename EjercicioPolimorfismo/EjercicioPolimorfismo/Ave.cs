
namespace EjercicioPolimorfismo
{
    public class Ave : Informacion
    {
        public Ave(string TipoMascota)
        {
            this.TipoMascota = TipoMascota;
        }

        public Ave(string TipoMascota, double Precio)
        {
            this.TipoMascota = TipoMascota;
            this.Precio = Precio;
        }
    }
}

//Polimorfismo mediante Listas
using EjercicioPolimorfismo;

List<Mascota> mascotaLista = new List<Mascota>();
string opcion = "";

do
{
    Console.WriteLine("-------- TIENDA DE MASCOTAS --------");
    Mascota mascota = new Mascota();
    Console.WriteLine("Ingrese el nombre del dueño de la mascota:");
    mascota.Dueño = Console.ReadLine();
    Console.WriteLine("Ingrese tipo de mascota:");
    mascota.Tipo = Console.ReadLine();
    Console.WriteLine("Ingrese el precio:");
    mascota.Precio = Convert.ToDouble(Console.ReadLine());
    mascotaLista.Add(mascota);
    Console.WriteLine("¿Desea continuar? (S/N o s/n)");
    opcion = Console.ReadLine();
} while (opcion.ToUpper() != "N");

Console.WriteLine();
Console.WriteLine("********** LISTA DE MASCOTAS **********");
foreach (Mascota mascota in mascotaLista)
{
    mascota.Vendida();
}
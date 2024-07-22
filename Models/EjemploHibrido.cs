using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models
{
    public class EjemploHibrido
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte AlturaEnCm { get; set; }
        public static DateTime FechaActual = DateTime.Now;

        public EjemploHibrido(int id, string nombre, string apellido, byte alturaEnCm)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            AlturaEnCm = alturaEnCm;
        }

        public void Mostrarinformacion()
        {
            Console.WriteLine($@"
    Id: {Id} 
    Nombre: {Nombre} 
    Apellido: {Apellido} 
    Altura: {AlturaEnCm} cm
    ");
        }

        public static void MostrarHead()
        {
            Console.WriteLine("######################");
            Console.WriteLine("       Detalles       ");
            Console.WriteLine("######################");

        }

        public static void MostratFooter()
        {
            Console.WriteLine("----------------------");

        }

    }
}
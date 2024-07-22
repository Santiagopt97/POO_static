using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

    public static class EjemploEstatico //Si la clase es estatica, todas sus propiedades y metodos si o si deben ser estaticos, si se deja la clase normal permite el uso hibrido de estatico y no estatico
    {
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        
        static EjemploEstatico()
        {
            Nombre = "Santiago";
            Apellido = "Pineda";
        }

        public static void Saludar(){
            Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido}");
        }
    }

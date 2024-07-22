using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

    public class EjemploEstatico
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public EjemploEstatico()
        {
            Nombre = "Santiago";
            Apellido = "Pineda";
        }

        public void Saludar(){
            Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido}");
        }
    }

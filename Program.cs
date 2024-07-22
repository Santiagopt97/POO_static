using POO_static.Models;
//El static permite acceder a las propiedades y metodos estaticos de una clase sin tener que instanciar la clase.

//Uso de propiedades y metodos
// Console.Clear();
// var ejemplo1 = new Ejemplo();
// Console.WriteLine(ejemplo1.Nombre);
// Console.WriteLine(ejemplo1.Apellido);

// ejemplo1.Saludar();

// //Uso de propiedades y metodos con static
// EjemploEstatico.Nombre = "david";
// EjemploEstatico.Apellido = "Pineda";

// Console.WriteLine($"Nombre: {EjemploEstatico.Nombre}");
// Console.WriteLine($"Nombre: {EjemploEstatico.Apellido}");
// EjemploEstatico.Saludar();

//Uso de constructor estatico
// EjemploEstatico.Saludar();

EjemploHibrido.MostrarHead();
var nuevoUsuario = new EjemploHibrido(1, "santiago", "pineda", 168);
Console.WriteLine(EjemploHibrido.FechaActual); 
nuevoUsuario.Mostrarinformacion();
EjemploHibrido.MostratFooter();

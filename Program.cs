using Corto.MisClases;
Console.WriteLine("Ingrese el nombre de la persona:");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese la edad de la persona:");
int edad = int.Parse(Console.ReadLine());

ClsPersona persona = new ClsPersona(nombre, edad);

persona.DecirMiNombre();
persona.cumpirAños();
persona.cumpirAños();
persona.cumpirAños();
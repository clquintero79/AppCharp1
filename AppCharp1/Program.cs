
using System;

namespace AppCharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 5;
            string nombre, ape,ciudad;
            var pelicula = "EndGame";
            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine($"Bienvenido {nombre} tienes {edad} años");
            Console.WriteLine($"Próximo estreno {pelicula} 25 de abril ");
            Console.WriteLine($"Esto lo hice desde la cuenta lorenaquint@gmail.com");
            Console.WriteLine($"Ahora si estoy haciendo esto desde lorenquint@gmail.com");
            Console.ReadLine();
        }
    }
}

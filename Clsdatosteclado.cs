using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1_Consola_Puma
{
    class Clsdatosteclado
    {
        static void Main(string[] args)
        {
            //declarar variables
            string nombre;
            string apellido;
            int edad;
            double talla;
            bool sexo;
            string email;
            

            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellidos: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese talla: ");
            talla = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sexo: ");
            sexo = bool.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese email: ");
            email = Console.ReadLine();
            Console.WriteLine("==================================");
            Console.WriteLine("|| DATOS PERSONALES DEL USUARIO ||");
            Console.WriteLine("==================================");
            Console.WriteLine("Nombres y apellidos: " + nombre + " " + apellido);
            Console.WriteLine("Edad " + edad);
            Console.WriteLine("Talla " + talla);
            Console.WriteLine("Sexo " + sexo);
            Console.WriteLine("Email " + email);
        }
    }
}

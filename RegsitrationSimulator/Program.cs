using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNAD_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
        MostrarInformacionInicial();//llamo al metodo

        Console.Write("Ingrese la contraseña de acceso: ");
        string contraseña = Console.ReadLine(); //se crea la variable contraseña

        if (contraseña == "123")// usamos un condicional
        {
            Console.WriteLine("\nAcceso autorizado\n");

            Console.WriteLine("Ingrese los datos del estudiante:");

            Console.Write("Número de Identificación: ");
            string identificacion = Console.ReadLine();

            Console.Write("Cantidad de créditos a Matricular: ");
            int cantidadCreditos = Convert.ToInt32(Console.ReadLine()); //Convierte la representación en forma de cadena en un número en el entero 

            Console.Write("Estrato a que pertenece: ");
            int estrato = Convert.ToInt32(Console.ReadLine());

            Console.Write("Género (M/F): ");
            char genero = Convert.ToChar(Console.ReadLine());//lo utilizamos como es solo una letra

            string certificadoElectoral;
            do
            {
                Console.Write("¿Tiene Certificado Electoral? (Si/No): ");
                certificadoElectoral = Console.ReadLine();
            } while (certificadoElectoral.ToLower() != "si" && certificadoElectoral.ToLower() != "no");//tolower para letras mayusculas

            double valorCredito = 123000;
            double valorTotal = cantidadCreditos * valorCredito;

            double descuentoEstrato = 0;
            switch (estrato)
            {
                case 1:
                case 2:
                    descuentoEstrato = 0.15;
                    break;
                case 3:
                case 4:
                    descuentoEstrato = 0.10;
                    break;
                case 5:
                case 6:
                    descuentoEstrato = 0.05;
                    break;
            }

            double descuentoCertificado = certificadoElectoral.ToLower() == "si" ? 0.10 : 0;//tolower para que no de error por letras mayusculas

            double descuentoTotal = valorTotal * (descuentoEstrato + descuentoCertificado);
            double valorAPagar = valorTotal - descuentoTotal;

            Console.WriteLine("\nResumen de Matrícula:");

            Console.WriteLine("Nombre: Maicol David Siachoque Cubides");
            Console.WriteLine("Grupo del curso: 46 ");
            Console.WriteLine("Identificación: " + identificacion);
            Console.WriteLine("Cantidad de créditos matriculados: " + cantidadCreditos);
            Console.WriteLine("Estrato: " + estrato);
            Console.WriteLine("Género: " + genero);
            Console.WriteLine("Certificado Electoral: " + certificadoElectoral);
            Console.WriteLine("Valor a pagar por matrícula: $" + valorAPagar.ToString("N2"));
            Console.WriteLine("Descuento obtenido: " + (descuentoTotal).ToString("N2") + "%");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Acceso denegado.");
        }

        Console.WriteLine("\nPulse cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void MostrarInformacionInicial()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Bienvenido al Simulador de Matrícula");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Nombre: Maicol David Siachoque Cubides");
        Console.WriteLine("Grupo del curso: 46 ");
        Console.WriteLine();
    }

        
    }
}


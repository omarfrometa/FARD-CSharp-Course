using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*            C# FARD           *");
            Console.WriteLine("*********************************");

            Console.WriteLine("");
            Console.WriteLine("Ejecuta el Ejemplo:");
            Console.WriteLine("#1. Suma de Numeros");
            Console.WriteLine("#2. Calculo de Promedios");
            Console.WriteLine("#3. Lectura de Archivo de Texto");

            var seleccion = Convert.ToInt32(Console.ReadLine());

            if (seleccion == 1)
            {
                Ejemplo1();
            } else if (seleccion == 2)
            {
                Ejemplo2();
            }
            else if (seleccion == 3)
            {
                Ejemplo3();
            }
        }

        static void Ejemplo1()
        {
            int valor1 = 0;
            int valor2 = 0;

            Console.WriteLine("*********************************");
            Console.WriteLine("*            CAL FARD           *");
            Console.WriteLine("*********************************");

            Console.WriteLine("");

            Console.WriteLine("SUMA");
            Console.WriteLine("Digita el 1er Numero:");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digita el 2do Numero:");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El Resueltado: {(valor1 + valor2)}");
            Console.WriteLine("El Resueltado: " + (valor1 + valor2));

            Console.ReadLine();
        }

        static void Ejemplo2()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*            CAL FARD           *");
            Console.WriteLine("*********************************");

            Console.WriteLine("");

            //Declaracion de Variables
            string nombreCompleto;
            int nota1, nota2, nota3, nota4;
            double promedio;

            //Captura de Valores
            Console.WriteLine("Digite su Nombre:");
            nombreCompleto = Console.ReadLine();

            Console.WriteLine("Digite la Nota #1:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la Nota #2:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la Nota #3:");
            nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la Nota #4:");
            nota4 = Convert.ToInt32(Console.ReadLine());

            //Proceso
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("");
            Console.WriteLine($"El promedio final para {nombreCompleto.ToUpper()} es: {promedio}");
            Console.ReadLine();
        }

        static void Ejemplo3()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*            CAL FARD           *");
            Console.WriteLine("*********************************");

            Console.WriteLine("");

            var path = System.AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine("Ruta 1");
            Console.WriteLine(path);

            Console.WriteLine("Leyendo Archivo personas.txt");
            Console.WriteLine("");

            StreamReader streamReader = new StreamReader(path + "personas.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            streamReader.Close();
            Console.ReadLine();
        }
    }
}

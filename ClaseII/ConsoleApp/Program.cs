using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejemplo4();
        }

        static void Teoria()
        {
            /*
             * TIPO DE DATOS *

             DATOS ENTEROS             
                    byte        Byte        0               hasta       255
                    sbyte       Sbyte       -128            hasta       127
                    int         Int32       -2.147.483.648  hasta       2.147.483.647
                    uint        UInt32
                    short       Int16
                    long        Int64
                    ulong       UInt64

              DATOS DE PRECISION
                    float       Single      -3M             hasta       3M
                    double      Double      
                    decimal     Decimal
            
             OTROS TIPOS DE DATOS
                    char        Char
                    string      String
                    bool        Boolean
                    object      Object
                    dynamic
                    date        DateTime
             */

            string nombreVariableString = "FARD"; //variable tipo String
            int nombreVariableEntero = 0; //variable tipo Entero
            double nombreVariableDouble = 50; //variable tipo Double

            int a = 0;
            decimal b = 0;
            float c = 0;
            double d = 0;
            string e = "Hola Chicos de la FARD";
            bool f = false;
            DateTime g = DateTime.Now;

            Console.WriteLine("TIPOS DE DATOS");
            Console.WriteLine("");

            Console.WriteLine("El valor de a es: {0}", a);
            Console.WriteLine("El valor de b es: {0:C}", b);
            Console.WriteLine("El valor de c es: {0:F2}", c);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de e es: " + e);
            Console.WriteLine("El valor de f es: " + f.ToString());
            Console.WriteLine($"El valor de g es: {g.ToString("F")}");

            //OPERADORES NUMERICOS

            //CAMBIO DE SIGNO           -, +
            //ARITMETRICOS              +, -, *, /, %
            //INCREMENTO                ++, --

            //OPERADORES COMPARACION
            //MAYOR QUE                 >
            //MENOR QUE                 <
            //IGUAL A                   ==
            //MAYOR O IGUAL QUE         >=
            //MENOR O IGUAL QUE         <=
            //DISTINTO QUE              !+
        }

        static void Ejemplo1()
        {
            Console.WriteLine("EJEMPLO OPERADORES ARITMETRICOS");
            Console.WriteLine("");

            Console.WriteLine("Operadores");
            Console.WriteLine("Digita el Numero 1: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digita el Numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Resultados");

            Console.WriteLine($"Suma: {(numero1 + numero2)}");
            Console.WriteLine($"Resta: {(numero1 - numero2)}");
            Console.WriteLine($"Multiplicacion: {(numero1 * numero2)}");
            Console.WriteLine($"Division: {(numero1 / numero2)}");

            Console.WriteLine($"Potencia: {Math.Pow(numero1, numero2)}");
            Console.WriteLine($"Raiz Cuadrada: {Math.Sqrt(numero1)}");

            Console.ReadLine();
        }

        static void Ejemplo2()
        {
            //CONVERSIONES DE TIPOS 

            double w;
            long x;
            long y;
            long z;

            w = 21.234323;

            //FORMAS DE CONVERSION
            x = (long)w;
            y = Convert.ToInt64(x);
            z = long.Parse(x.ToString());

            //Console.WriteLine("El valor de x es: " + x);
            //Console.WriteLine("El valor de y es: " + y);
            //Console.WriteLine("El valor de z es: " + z);

            //CONVERSION DE FECHAS
            DateTime fechaDeHoy = DateTime.Now;

            Console.WriteLine("AÑOS");
            //Console.WriteLine(String.Format("{0: y yy yyy yyyy}", fechaDeHoy));
            //Console.WriteLine(String.Format("{0: M MM MMM MMMM}", fechaDeHoy));
            //Console.WriteLine(String.Format("{0: d dd ddd dddd}", fechaDeHoy));

            Console.WriteLine($"Fecha de Hoy Completa: {fechaDeHoy.ToString("F")}");
            Console.WriteLine($"Fecha de Hoy Completa: {fechaDeHoy.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Fecha de Hoy Completa: {fechaDeHoy.ToString("MMM dd, yyyy")}");
            Console.WriteLine($"Hora de Hoy Completa: {fechaDeHoy.ToString("hh:mm:ss tt")}");
            Console.WriteLine($"Fecha: {fechaDeHoy.ToString("dd-MM-yyy")} | Hora: {fechaDeHoy.ToString("hh:mm:ss tt")}");
            Console.ReadLine();
        }

        static void Ejemplo3()
        {
            TimeZoneInfo zoneInfo = TimeZoneInfo.Local;
            Console.WriteLine($"Local Time Id: {zoneInfo.Id}");
            Console.WriteLine($"Display Name: {zoneInfo.DisplayName}");
            Console.WriteLine($"Standard: {zoneInfo.StandardName}");
            Console.WriteLine($"Daylight: {zoneInfo.DaylightName}");

            Console.ReadLine();
        }

        static void Ejemplo4()
        {
            int valor1 = 0;
            int valor2 = 0;

            Console.WriteLine("Digita el Primer valor:");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digita el Segundo valor:");
            valor2 = Convert.ToInt32(Console.ReadLine());

            if (valor1 <= valor2)
            {
                if (valor1 == valor2)
                {
                    Console.WriteLine($"El valor 1 ({valor1}) es igual al valor 2 ({valor2})");
                }
                else
                {
                    Console.WriteLine($"El valor 2({valor2}) es mayor al valor 1({valor1})");
                }
            }
            else
            {
                Console.WriteLine($"El valor 1({valor1}) es mayor que el valor 2({valor2})");
            }

            Console.ReadKey();
        }
    }
}

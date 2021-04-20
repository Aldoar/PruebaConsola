using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi primer proyecto en C#!!");
            Console.WriteLine("============");
            bool salir = false;
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("1- Calcular la edad");
                Console.WriteLine("2- Mayor de edad");
                Console.WriteLine("3- Contar");
                Console.WriteLine("4- Calcular el Promedio");
                Console.WriteLine("5- Calculadora");
                Console.WriteLine("9- Limpiar Pantalla");
                Console.WriteLine("0- Salir");
                Console.WriteLine("Seleccione una opción:");
                opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                         calcularEdad();
                        break;
                    case "2":
                        mayorEdad();
                        break;
                    case "3":
                        contar();
                        break;              
                    case "9":
                        limpiarConsola();
                        break;
                    case "0":
                        salir = true;
                        Console.WriteLine("Presione una tecla para salir");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción valida");
                        break;
                }
            } while (!salir);
        }
        private static void limpiarConsola()
        {
            Console.Clear();
        }
        private static int calcularEdad()
        {
            int dia = 0;
            int mes = 0;
            int anno = 0;
            string datos = string.Empty;
            Console.WriteLine("Ingrese día de nacimiento:");
            datos = Console.ReadLine();
            dia = Convert.ToInt32(datos);
            Console.WriteLine("Ingrese mes de nacimiento:");
            datos = Console.ReadLine();
            mes = Convert.ToInt32(datos);
            Console.WriteLine("Ingrese año de nacimiento:");
            datos = Console.ReadLine();
            anno = Convert.ToInt32(datos);
            DateTime fechaNacimiento = new DateTime(anno, mes, dia);
            int edad =  DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;

            Console.WriteLine("La cantidad de años son: "+edad);
            Console.WriteLine();
            Console.WriteLine();
            return edad;
        }
        private static void mayorEdad()
        {
            int edad = calcularEdad();
            if(edad >= 18)
            {
                Console.WriteLine("Sí es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
        }
        private static void contar()
        {
            int contar = 0;
            string cantidad = string.Empty;
            Console.WriteLine("Hasta que número deseas contar");
            cantidad = Console.ReadLine();
            int.TryParse(cantidad, out contar);

            if (contar <= 0)
            {
                Console.WriteLine("No se puede contar, por que ingresaste " + cantidad);
            }
            else
            {
                for (int i = 1; i <= contar; i++)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}

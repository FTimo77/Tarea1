using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Tarea1
{
    class Ejercicio2
    {
        public static void Ejecutar()
        {
            // Ejercicio 2.1
            Console.WriteLine("Ejercicio 2.1:");
            Console.WriteLine("Ingresa un número para determinar si es positivo, negativo o cero");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else
            {
                Console.WriteLine("Es cero");
            }

            //Ejercicio 2.2
            Console.WriteLine("Ejercicio 2.2:");
            Console.WriteLine("Ingrese una calificación (del 0 al 100)");
            int calificacion = int.Parse(Console.ReadLine());
            if (calificacion >= 60)
            {
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("REPROBADO");
            }

            //Ejercicio 2.3
            Console.WriteLine("Ejercicio 2.3:");
            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());
            if (numero < 10)
            {
                Console.WriteLine("Menor que 10");
            }
            else if (numero > 10 && numero < 20)
            {
                Console.WriteLine("Entre 10 y 20");
            }
            else
            {
                Console.WriteLine("Mayor que 20");
            }

            //Ejercicio 2.4
            Console.WriteLine("Ejercicio 2.4:");
            Console.WriteLine("Ingrese un número del 1 al 7:");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }

            //Ejercicio 2.5
            Console.WriteLine("Ejercicio 2.5:");
            Console.WriteLine("Ingrese la operación a realizar(+, -, *, /)");
            string operacion = Console.ReadLine();
            Console.WriteLine("Ingrese el primer número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int numero2 = int.Parse(Console.ReadLine());
            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case "-":
                    Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case "*":
                    Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                    break;
                case "/":
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                    break;
            }
            Console.ReadLine();
        }
        }
}
    

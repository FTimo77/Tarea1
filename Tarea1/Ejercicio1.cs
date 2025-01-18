using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.1
            Console.WriteLine("Ejercicio 1.1");
            for(int i=0; i < 101; i += 2) //bucle for con incremento de 2 para mostrar los numeros pares hasta el 100
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Ejercicio 1.2
            Console.WriteLine("Ejercicio 1.2");
            for (int i = 0; i < 101; i++)
            {
                bool par = i % 2 == 0; //Creamos un booleano para determinar si es divisible a 2 en cada ciclo
                if (par)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            //Ejercicio 1.3
            Console.WriteLine("Ejercicio 1.3");
            for (int i = 1; i < 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) //validar si es divisible para 5 y 3
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if (i % 3 == 0) //validar si es divisible para 3
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if (i % 5 == 0) //validar si es divisible para 5
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else //imprimir el numero sin mas en todos los demas casos
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            //Ejercicio 1.4
            Console.WriteLine("Ejercicio 1.4");
            int j = 1;
            while (j < 11)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();

            //Ejercicio 1.5
            Console.WriteLine("Ejercicio 1.5");
            j = 0;
            int suma = 0;
            while (j < 101)
            {
                suma += j; //Sumar cada valor del 1 al 100 en cada ciclo
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine(suma); //Imprimir la suma total
            Console.ReadLine();

            //Ejercicio 1.6
            j = 1;
            while (j < 101)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();

            Ejercicio2.Ejecutar();
        }
    }
}
 
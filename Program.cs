//Tarea de Semana 10 - Funciones.

using System;
using System.Collections.Generic;

namespace ProgramNum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int respuesta;
            int opcion;

            do
            {
                System.Console.WriteLine("Elija una opcion. \n \n1- Recibir un Nombre y saludar. \n2- Recibir un numero de dos digitos y retornar el ulitmo. \n3- Recibir un numero y confirmar si es Par o Impar. \n4- Recibir un numero de dos digitos y mostar la tabla de multiplicar del primer digito hasta el limete del ultimo digito. \n5- Recibir un numero de dos digitos Y retornar el mayor de los dos. \n \n9- Salir del programa \n ");
                System.Console.Write("Elija un Programa que quiere probar: ");
                opcion = Convert.ToInt32(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Opcion1();
                        System.Console.WriteLine("\n \n Pulse ENTER para salir de esta Opción");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Console.Clear();
                        Opcion2();
                        System.Console.WriteLine("\n \n Pulse ENTER para salir de esta Opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        opcion3();
                        System.Console.WriteLine("\n \n Pulse ENTER para salir de esta Opción");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:
                        Console.Clear();
                        opcion4();
                        System.Console.WriteLine("\n \n Pulse ENTER para salir de esta Opción");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 5:
                        Console.Clear();
                        opcion5();
                        System.Console.WriteLine("\n \n Pulse ENTER para salir de esta Opción");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    default: System.Console.WriteLine("ERROR - OPCION NO VALIDA, ELIDA UN NUMERO DENTRO DEL RANGO 1 - 5"); break;
                }

                Console.Clear();
                System.Console.Write("¿Desea ir al menu principal o salir del programa? \n1- Ir al menu \n9- Salir del Programa \n \nDigite el numero de su respuesta:");
                respuesta = Convert.ToInt32(Console.ReadLine()!);
                Console.Clear();

            } while (respuesta != 9);

            System.Console.WriteLine("Saliendo del programa.");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Saliendo del programa..");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine("Saliendo del programa...");
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void Opcion1()
        {
            System.Console.Write("¿Cual es Su nombre? ");
            string nombre = Console.ReadLine()!;

            System.Console.WriteLine("");
            System.Console.WriteLine($"Hola {nombre}, ¿Que tal te va?");
        }

        static void Opcion2()
        {
            string programa;
            int a, b;

            do
            {
                System.Console.Write("Digite un numero de dos Digitos: ");
                int n = Convert.ToInt32(Console.ReadLine()!);

                if (n >= 100)
                {
                    Console.Clear();
                    System.Console.WriteLine("Solo se permiten un numero de dos digitos \n ");
                }

                if (n < 99)
                {
                    Console.Clear();
                    b = n % 10;
                    n = n / 10;
                    a = n % 10;

                    System.Console.WriteLine($"El ultimo digito del numero ingresado es {b} \n");
                }

                System.Console.Write("¿Desea repetir este mismo programa? ");
                programa = Console.ReadLine()!;
                Console.Clear();

            } while (programa != "no");
        }

        static void opcion3()
        {
            System.Console.Write("Digite un numero: ");
            int desicion = Convert.ToInt32(Console.ReadLine()!);

            if (desicion % 2 == 0)
            {
                System.Console.WriteLine($"El numero {desicion} es Par.");
            }

            else
            {
                System.Console.WriteLine($"El numero {desicion} es Impar");
            }
        }

        static void opcion4()
        {
            int n, a, b;
            string respuesta;

            do
            {
                System.Console.Write("Ingre un numero de dos digitos: ");
                n = Convert.ToInt32(Console.ReadLine()!);

                if (n >= 100)
                {
                    Console.Clear();
                    System.Console.WriteLine("Solo se permiten numeros de Dos digitos \n \n");
                }

                if (n <= 99)
                {
                    b = n % 10;
                    n = n / 10;
                    a = n % 10;

                    for (int i = a; a <= b; a++)
                    {
                        System.Console.WriteLine($"{a} X {b} = " + a * b);
                    }
                }

                System.Console.Write("¿Desea repetir este programa?  ");
                respuesta = Console.ReadLine()!;
                Console.Clear();

            } while (respuesta != "no");

        }

        static void opcion5()
        {
            int digito;
            int a, b;
            do
            {
                System.Console.Write("Digite un numero de dos digitos: ");
                digito = Convert.ToInt32(Console.ReadLine()!);

                if (digito >= 100)
                {
                    Console.Clear();
                    System.Console.WriteLine("ERROR - USTED HA DIGITADO UN NUMERO MAYOR A 100 \nDigite un numero de solo dos digitos");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (digito >= 100);

            if (digito <= 99)
            {
                b = digito % 10;
                digito = digito / 10;
                a = digito % 10;

                System.Console.WriteLine("");

                if (a > b)
                {
                    System.Console.WriteLine($"Del numero ingresado, el primer digito ingresado {a} es mayor que el segundo digito {b}");
                }
                else
                {
                    System.Console.WriteLine($"Del numero ingresado, el segundo digito ingresado {b} es mayor que el primer digito {a}");
                }
            }
        }
    }

    public string llamar_a_fulanito()
    {
        
    }
}
﻿using Mariano_LABPROG.Models;

internal class Program
{
    /*
        Consigna
        Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

        Deberá tener los atributos:

        -titular que contendrá la razón social del titular de la cuenta.
        -cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.

        Construir los siguientes métodos para la clase:

        Un constructor que permita inicializar todos los atributos.
        Un método getter para cada atributo.
        mostrar retornará una cadena de texto con todos los datos de la cuenta.
        ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
        retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
    */

    private static void Main(string[] args)
    {
        bool seguir = true;
        int numero = 0;
        int dinero = 0;
        Cuenta cuenta = new Cuenta(1000, 2000);

        do
        {
            cuenta.Mostrar();

            Console.Write("Ingrese un numero:\n1-Ingresar Dinero\n2-Sacar Dinero : ");
            numero = int.Parse(Console.ReadLine());

            if(numero == 1)
            {
                Console.Write("Ingrese la suma de dinero a ingresar : ");
                dinero = int.Parse(Console.ReadLine());
                cuenta.Ingresar(dinero);
            }
            else
            {
                Console.Write("Ingrese la suma de dinero a retirar : ");
                dinero = int.Parse(Console.ReadLine());
                cuenta.Retirar(dinero);

            }


            Console.WriteLine("Desea seguir ? 1-Si/2-No");
            numero = int.Parse(Console.ReadLine());

            if(numero == 2)
            {
                seguir = false;
            }

            dinero = 0;
            Console.Clear();

        } while (seguir);

        Console.WriteLine("FIN DEL PROGRAMA...");
        Console.ReadKey();
    }
}
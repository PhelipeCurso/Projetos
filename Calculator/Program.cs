﻿// See https://aka.ms/new-console-template for more information
using System;
 class Program
{
   
    

    static void Main(string[] args)
    { 
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Selecione a operação desejada");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("------------------");
        Console.WriteLine("selecione uma opção");
        short opcao = short.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Finalizar(); break;
            default: Menu(); break;
        }

    }
        static void Soma()
        {   
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());


        Console.WriteLine("Segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da subtração é " + resultado);
        Console.WriteLine($"O resultado da subtração é: {resultado}");

        Console.ReadKey();
        Menu();

    }

        static void Divisao()
        {
          Console.Clear();

          Console.WriteLine("Primeiro valor");
          float v1 = float.Parse(Console.ReadLine());

          Console.WriteLine("Segundo valor");
          float v2 = float.Parse(Console.ReadLine());
          Console.WriteLine("");

          float resultado = v1/ v2;
          Console.WriteLine($"O resultado da divisão é {resultado}");
          Console.ReadKey();
          Menu();

        }


       static void Multiplicacao(){
        Console.Clear();
        Console.WriteLine("Primeiro valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine(""); 

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da divisão é {resultado}");
        Console.ReadKey();
        Menu();

       }
    
    static void Finalizar(){
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar nosso sistema");
        System.Environment.Exit(0);

    }

}

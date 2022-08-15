using System;

namespace Calculadora_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string valor;

            Console.WriteLine("Digite el primer numero");
            num1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Digite el simbolo + si lo quiere sumar");
            Console.WriteLine("Digite el simbolo - si lo quiere restar");
            Console.WriteLine("Digite el simbolo x si lo quiere multiplicar");
            Console.WriteLine("Digite el simbolo / si lo quiere dividir");
            valor = Console.ReadLine();

            switch (valor)
            {
                case "+":
                    Console.WriteLine("Digite el numero 2");
                    num2 = Single.Parse(Console.ReadLine());
                    float suma = (num1 + num2);
                    Console.WriteLine("La suma es" + suma);
                    Console.ReadKey();
                    break;

                case "-":
                    Console.WriteLine("Digite el numero 2");
                    num2 = Single.Parse(Console.ReadLine());
                    float resta = (num1 - num2);
                    Console.WriteLine("La resta es" + resta);
                    Console.ReadKey();
                    break;

                case "x":
                    Console.WriteLine("Digite el numero 2");
                    num2 = Single.Parse(Console.ReadLine());
                    float multiplicacion = (num1 * num2);
                    Console.WriteLine("La multiplicacion es" + multiplicacion);
                    Console.ReadKey();
                    break;

                case "/":
                    Console.WriteLine("Digite el numero 2");
                    num2 = Single.Parse(Console.ReadLine());
                    float division = (num1 / num2);
                    Console.WriteLine("La division es" + division);
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Presione cualquier tecla para salir");
                    break;
            }



        }
    }
}

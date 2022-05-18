using System;


namespace Calculadora
{
    public class Program 
    {
        public static void Main()
        {

            Console.Clear();
            Terminal.TextoCentralizadoNovaLinha("-----------------");
            Terminal.TextoCentralizadoNovaLinha("** Calculadora **");
            Terminal.TextoCentralizadoNovaLinha("-----------------");

            Terminal.TextoCentralizado("Primeiro número: ");
            float primeiroNumero = Convert.ToSingle(Console.ReadLine());

            Terminal.TextoCentralizado("Segundo número: ");
            float segundoNumero = Convert.ToSingle(Console.ReadLine());

            float resultado = primeiroNumero + segundoNumero;

            Console.WriteLine();
            Terminal.TextoCentralizadoNovaLinha(
                $"Soma de { primeiroNumero } + { segundoNumero } = { resultado }"
            );

            Console.WriteLine();
        }
    }
}

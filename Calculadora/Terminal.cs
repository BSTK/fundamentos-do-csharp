using System;

namespace Calculadora
{
    public class Terminal
    {
        private static readonly int WINDOW_WIDTH_TEXTO_CENTRALIZADO = Console.WindowWidth / 2;

        public static void TextoCentralizado(string texto = "")
        {
            var margemEsquerda = MargemEsquerda(texto);
            Console.Write(texto.PadLeft(margemEsquerda));
        }

        public static void TextoCentralizadoNovaLinha(string texto = "")
        {
            var margemEsquerda = MargemEsquerda(texto);
            Console.WriteLine(texto.PadLeft(margemEsquerda));
        }

        private static int MargemEsquerda(string texto)
        {
            if (texto == null)
            {
                throw new ArgumentNullException(texto, "Texto não pode ser nulo!");
            }

            return WINDOW_WIDTH_TEXTO_CENTRALIZADO + (texto.Length / 2);
        }
    }
}

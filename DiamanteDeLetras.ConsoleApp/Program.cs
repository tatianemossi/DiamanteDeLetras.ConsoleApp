using System;
using System.Linq;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qualquer letra de A a Z: ");
            var letraDigitada = Console.ReadLine();

            int letraConvertidaEmNumero = char.ToUpper(letraDigitada.ToCharArray().Single()) - 64;

            int espacoEmBrancoAntesDasLetras = letraConvertidaEmNumero - 1;
            int espacoEntreAsLetras = 0;
            
            for (int linha = 1; linha <= letraConvertidaEmNumero; linha++)
            {
                for (int i = 0; i < espacoEmBrancoAntesDasLetras; i++)
                {
                    Console.Write(" ");
                }
                var charConvertida = ((char)(linha + 64)).ToString();

                Console.Write(charConvertida);
                
                for (int i = 0; i < espacoEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }

                if (espacoEntreAsLetras == 0)
                {
                    espacoEntreAsLetras++;
                }
                else
                {
                    espacoEntreAsLetras+=2;
                    Console.Write(charConvertida);
                }

                espacoEmBrancoAntesDasLetras--;
                                                
                Console.WriteLine();
            }

            int espacoEmBrancoAntesDasLetras2 = 1;
            int espacoEntreAsLetras2 = espacoEntreAsLetras - 4;

            for (int linhaDeBaixo = letraConvertidaEmNumero - 1; linhaDeBaixo >= 1; linhaDeBaixo--)
            {
                for (int i = 0; i < espacoEmBrancoAntesDasLetras2; i++)
                {
                    Console.Write(" ");
                }

                var charConvertida = ((char)(linhaDeBaixo + 64)).ToString();

                Console.Write(charConvertida);

                for (int i = 0; i < espacoEntreAsLetras2; i++)
                {
                    Console.Write(" ");
                }

                if (linhaDeBaixo != 1)
                {
                    Console.Write(charConvertida);
                }
                
                espacoEmBrancoAntesDasLetras2++;
                espacoEntreAsLetras2-=2;
                
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

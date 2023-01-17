using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace FizzBuzzLul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Digite um número inteiro:");
            input = Convert.ToInt32(Console.ReadLine());
            int[] valores;
            int[] multiplo3; 
            int[] multiplo5;
            string[] resultado;


            // insere todos valores multiplos de 3 até o valor inputado no array multiplo3
            multiplo3 = new int[input / 3];
            for (int i = 0; i < multiplo3.Length; i++)
            {
                int value = i + 1;
                //multiplo3.SetValue(value * 3, i);
                multiplo3[i] = value * 3;
            }

            // insere todos valores multiplos de 5 até o valor inputado no array multiplo5
            multiplo5 = new int[input / 5];
            for (int i = 0; i < multiplo5.Length; i++)
            {
                int value = i + 1;
                //multiplo5.SetValue(value * 5, i);
                multiplo5[i] = value * 5;
            }

            // insere todos valores inteiros até o valor inputado no array valores
            valores = new int[input];
            for (int i=0; i < input; i++)
            {
                int value = i + 1;
                valores.SetValue(value, i);
            }


            resultado = new string[input];
            for (int i=0; i<resultado.Length; i++)
            {
                int pos = i+1;
                string value = Convert.ToString(pos);
                if (multiplo3.Contains(pos))
                {
                    resultado[i] = resultado[i] + "Fizz";
                    if (multiplo5.Contains(pos))
                    {
                        resultado[i] = resultado[i] + "Buzz";
                    }
                } else if (multiplo5.Contains(pos))
                {
                    resultado[i] = resultado[i] + "Buzz";
                } else
                {
                    resultado[i] = value;
                }
                
            }
            for (int i=0; i< resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }

            Console.WriteLine("O programa finalizou sem nenhum erro.\n Pressione enter para sair.");
            Console.ReadLine();
        }
    }
}

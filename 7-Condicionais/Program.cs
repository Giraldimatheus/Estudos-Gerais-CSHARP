using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadejoao = 18;
            int quantidadepessoas = 1;
            if (idadejoao >= 18)
            {
                Console.WriteLine("Joao tem mais de 18 anos, pode entrar.");
            }
            else
            {
                if (quantidadepessoas >= 2)
                {
                    Console.WriteLine("Pode entrar...");
                }
                else { Console.WriteLine("Não tem 18 anos e ta sozin, não pode entrar vacilao"); }
            }

            Console.ReadLine();
        }
    }
}

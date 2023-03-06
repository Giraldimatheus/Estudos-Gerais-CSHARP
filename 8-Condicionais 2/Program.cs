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
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            
            int idadejoao = 18;
            //int quantidadepessoas = 1
            //bool acompanhado = quantidadepessoas >= 2;
            bool acompanhado = true;

            if (idadejoao >= 18 || acompanhado==true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar vacilao");
            }

            Console.ReadLine();
        }
    }
}

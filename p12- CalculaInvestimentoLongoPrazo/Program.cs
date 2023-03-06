using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12__CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");
            double ValorInvestido = 1000;
            double FatorRendimento = 1.0036;
            for(int ContadorAno = 1; ContadorAno <=5; ContadorAno++)
            {
                for(int ContadorMes= 1; ContadorMes <=12; ContadorMes++)
                {
                    ValorInvestido *= FatorRendimento;
                }


                FatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + ValorInvestido);

            Console.ReadLine();
        }
    }
}

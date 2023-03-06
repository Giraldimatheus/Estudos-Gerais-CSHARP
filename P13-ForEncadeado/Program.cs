using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            //para cada linha um for, para cada inclusão de * um for também.

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    if (contadorColuna <= contadorLinha)
                        Console.Write("*");
                    else
                        break;
                }

                Console.WriteLine();
            }

            //uma forma diferente de fazer a escrita

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                        Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

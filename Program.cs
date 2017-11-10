﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblVal1,dblVal2,dblRep=0;
            bool isOpIncorrect = true;

            Console.WriteLine("Calculatrice");
            Console.WriteLine("------------");

            Console.WriteLine("Saisir la première valeur");
             while(!double.TryParse(Console.ReadLine(), out dblVal1))
            {
                Console.Write("Saisir à nouveau la première valeur :");
            }

            Console.WriteLine("Saisir la deuxième valeur");
            while (!double.TryParse(Console.ReadLine(), out dblVal2))
            {
                Console.Write("Saisir à nouveau la deuxième valeur :");
            }

            Console.Write("Opération à choix [+ - * / ^]");
            while (isOpIncorrect)
            {

                string strOp = Console.ReadLine();
                isOpIncorrect = false;
                switch (strOp)
                {
                    default:
                        Console.WriteLine("Opération non reconnue par le système");
                        Console.WriteLine("Veuillez saisir à nouveau l'opérateur [+ - * / ^]");
                        break;
                    case "+":
                        dblRep = 0;
                        break;
                    case "-":
                        dblRep = 0;
                        break;
                    case "*":
                        dblRep = 0;
                        break;
                    case "/":
                        dblRep = 0;
                        break;
                }
            }
            Console.Write(dblVal1.ToString());

            Console.ReadKey();
        }
    }
}

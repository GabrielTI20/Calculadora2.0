using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double Valor1 = 0;
            double Valor2 = 0;
            double opcao = 0;
            
            //Está a exibir na tela para usúario
            Console.WriteLine("Digite o primeiro número: ");

            //Convert.ToDouble "Está convertendo uma string em double"
            //Console.ReadLine "Abre caixa texto para usuário digitar"
            Valor1=Convert.ToDouble(Console.ReadLine());

            //Está a exibir na tela para usúario
            Console.WriteLine("Digite o segundo número: ");

            //Convert.ToDouble "Está convertendo uma string em double"
            //Console.ReadLine "Abre caixa texto para usuário digitar"
            Valor2 = Convert.ToDouble(Console.ReadLine());

            // "/n" pula uma linha "/r" pula pra ultima linha
            Console.WriteLine("Qual operação você quer fazer? "  + "\n" 
               + "       1-Soma" + "\n" 
               + "       2-Subtração" +"\n" 
               + "       3-Divisão" + "\n" 
               + "       4-Multiplicação" + "\n" 
               + "       5-Nada, só estou dando uma olhadinha " + "\n");

            //Convert.ToDouble "Está convertendo uma string em double"
            opcao = Convert.ToDouble (Console.ReadLine());
            
            // "/if" condição 
            if(opcao== 1) 
            {
                Console.WriteLine("Valor da soma é: " + (Valor1 + Valor2));
            }
            else if (opcao== 2) 
            {
                Console.WriteLine("Valor da subtração é:"+(Valor1-Valor2));
               
            }
            else if (opcao== 3) 
            {
                
                if (Valor1 >= Valor2)
                {
                    Console.WriteLine("Valor da divisão é: " + (Valor1 / Valor2));
                }
                else
                {
                    Console.WriteLine("Invalido.");
                }
            }
            else if (opcao==4) 
            {
                Console.WriteLine("Valor da multiplicação é: " + (Valor1 * Valor2));
            }
            else if (opcao==5) 
            {
                Console.WriteLine("Aperte enter para fechar!");
            }




        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            double Valor1 = 0;
            double Valor2 = 0;
            string i = ""; 
           
            
            while (i != "2")
            {
               
                Console.WriteLine("Digite o primeiro número: ");
            
                Valor1=Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

            
                Valor2 = Convert.ToDouble(Console.ReadLine());

            
            
                Console.WriteLine("Calculadora " + "\n" + "\n"
               + "       1-Soma" + "\n" 
               + "       2-Subtração" +"\n" 
               + "       3-Divisão" + "\n" 
               + "       4-Multiplicação" + "\n" 
               + "       5-Nada, só estou dando uma olhadinha " + "\n" + "\n"
               + "Qual operação você quer fazer? ");


                switch (Console.ReadLine())
                {


                    case "1":
                        Console.WriteLine("Valor da soma é: " + (Valor1 + Valor2) + "\n");

                        break;


                    case "2":
                        Console.WriteLine("Valor da subtração é:" + (Valor1 - Valor2) + "\n");

                        break;


                    case "3":

                        if (Valor1 >= Valor2)
                        {
                            Console.WriteLine("Valor da divisão é: " + (Valor1 / Valor2) + "\n");

                        }

                        else
                        {
                            Console.WriteLine("Invalido." + "\n");

                        }

                        break;


                    case "4":

                        Console.WriteLine("Valor da multiplicação é: " + (Valor1 * Valor2) + "\n");

                        break;


                    case "5":


                        break;

                }
                Console.WriteLine("Quer continuar com a operações"
                + "\n" + "        1-sim"
                + "\n" + "        2-Não");
                i=Console.ReadLine();
                

            }
            
            
            
            
            



        }

    }
}
//"Double, int , string " e o tipo da variavel 

//Console.WhiteLine "Está a exibir na tela para usúario"

//Convert.ToDouble "Está convertendo uma string em double"

//Console.ReadLine "Abre caixa texto para usuário digitar"

// "/n" pula uma linha "/r" pula pra ultima linha



/*                                                                                                                          "Escondido"
            //Convert.ToDouble "Está convertendo uma string em double"
            opcao = Convert.ToDouble (Console.ReadLine());
            
            
            // "/if" condição de verificação
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
            }                                                                                                                           "Escondido"
            */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Compararitvos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Aprendendo operadores comparativos");

            /*Temos 6 operadores comparativos são eles
              == igau
            !=  diferente
            > maior
            < menor 
            >= maior ou igual
            <= menor ou igual */

            int numero1 = 10;
            bool resultado1 = numero1 > 10;
            
            Console.WriteLine("O Resultao é : "+resultado1);

            Console.WriteLine();

            int numero2 = 10;
            bool resultado2 = numero2 == 10;
            Console.WriteLine("O Resultado é :" + resultado2);

            Console.WriteLine();

            int numero3 = 10;
            bool resultado3 = numero3 != 12;
            Console.WriteLine("O Resultado é :" + resultado3);

            Console.WriteLine();

            int numero4 = 10;
            bool resultado4 = numero3 <= 12;
            Console.WriteLine("O Resultado é :" + resultado4);
            
            Console.WriteLine();

            int numero5 = 10;
            bool resultado5 = numero5 >= 12;
            Console.WriteLine("O Resultado é :" + resultado5);

            Console.WriteLine();

            string nome = "Pablo";
            bool resultado = nome == "Marcelo";
            Console.WriteLine("O Resultado é :" + resultado);

            string nome2 = "Pablo";
            bool resultadonome = nome2 == "Pablo";
            Console.WriteLine("O Resultado é :" + resultadonome);

            Console.WriteLine();
            Console.WriteLine("Aperte Enter para Sair! ");
            Console.ReadLine();
           
        }
    }
}

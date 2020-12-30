using System;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {

            // FACA UM ALGORITMO QUE LEIA O ANO DE NASCIMENTO E INFORME A IDADE

            int anonasc, anoatual, idade;
            Console.WriteLine("Informe o ano de seu nascimento (Ex: 1998):");
            anonasc = int.Parse(Console.ReadLine());

            anoatual = DateTime.Now.Year;

            idade = anoatual - anonasc;

            if(idade <= 1)
            {
                Console.WriteLine("Idade inválida");
            }

            else if (idade >=18)
            {
                Console.WriteLine("O usuário tem {0} anos - É de maior", idade);
            }
            else
            {
                Console.WriteLine("O usuário tem {0} anos - Não é de maior", idade);
            }

        }
    }
}

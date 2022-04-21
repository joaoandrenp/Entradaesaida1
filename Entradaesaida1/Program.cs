using System;

namespace Entradaesaida1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome = "Alex Green";
            int num = 3;
            double valor = 500.50123;
            String cor = "Green";
            int idade = 21;
            double tamanho = 1.73;

            Console.WriteLine("nome: "+nome+"/ numero: "+num);
            Console.WriteLine("valor: " + valor.ToString("F2"));
            Console.WriteLine("cor: "+cor);
            Console.WriteLine("idade: "+idade);
            Console.WriteLine("altura: "+tamanho);
            Console.WriteLine("------------------------------------");

            String produto = "computador";
            int preco = 2500;
            int quantidade = 10;
            int total = (preco * quantidade);

            Console.WriteLine("Produto: {0} \nPreço: {1}\nquantidade: {2}\nTotal: {3}",produto,preco,quantidade,total);
            Console.WriteLine("------------------------------------");

            String aluno = "joao andre";
            int introcsharp = 10;
            double projsolu = 8.6;
            int github = 10;
            double media = (introcsharp + projsolu + github) / 3;

            Console.WriteLine($"Aluno: {aluno}\nIntrodução ao C#: {introcsharp}\nCriar projeto e Solução: {projsolu:F2}\nEnviar ao GTIHUB: {github}\nMédia: {media:F2}");
        }
    }
}

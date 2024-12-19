using System;
using System.Security.Cryptography.X509Certificates;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // -=-=| 1 - Persorrendo um array |=-=-
            // Console.Clear();

            // var meuArray = new Teste[2];
            // meuArray[0] = new Teste();

            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);

            // -=-=| 2 - ForEach |=-=-
            // Console.Clear();

            // var funcionarios = new Funcionario[5];
            // funcionarios[0] = new Funcionario() { Id = 5643, Nome = "André" };

            // foreach (var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            //     Console.WriteLine(funcionario.Nome);
            // }

            // -=-=| 3 - Alterando os valores |=-=-
            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);
        }

        // -=-=| 1 - Persorrendo um array |=-=-
        //struct Teste{}

        // -=-=| 2 - ForEach |=-=-
        // public struct Funcionario
        // {
        //     public int Id { get; set; }
        //     public string Nome { get; set; }
        // }
    }
}
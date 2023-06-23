using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoLeoLeo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant1, quant2;
            string nome, produto1, produto2;

            //criação de nome
            Console.WriteLine("Bem-vindo ao sistema de estoque do Yosuke ");
            Console.WriteLine(" Digite o nome do funcionario responsavel:");
            nome = Console.ReadLine();
            Console.WriteLine("\n");

            //nome cadastrado
            Console.WriteLine($"O cadastro de estoque será feito no nome de {nome}");
            Console.WriteLine("\n");

            //cadastro dos produtos
            Console.WriteLine("-- CADASTRO DE PRODUTOS");
            Console.WriteLine("Digite o nome do Produto 1:");
            produto1 = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade em estoque de {produto1}");

            //colocando quantidade do produto1
            quant1 = Int32.Parse(Console.ReadLine());

            //cradastrando produto2
            Console.WriteLine("Digite o nome do Produto 2:");
            produto2 = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade em estoque de {produto2}");

            //colocando quantidade do produto2
            quant2 = Int32.Parse(Console.ReadLine());

            //produtos cadastrados e com quantidade
            Console.WriteLine("");
            Console.WriteLine("- Os produtos foram cadastrados com sucesso!");
            Console.WriteLine("");
            Console.WriteLine($"-- LISTA DE PRODUTOS CADASTRADOS POR {nome}:");
            Console.WriteLine($"{produto1} contém {quant1} itens em estoque");
            Console.WriteLine($"{produto2} contém {quant2} itens em estoque");
            //soma das quantidades de produtos
            Console.WriteLine($"- Total de itens no estoque: {quant1 + quant2} ");
            Console.WriteLine("");
            Console.WriteLine("----- FIM DO SISTEMA -----");

            Console.ReadKey();
        }
    }
}

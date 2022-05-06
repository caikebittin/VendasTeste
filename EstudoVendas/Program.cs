//criar classe produto, prop codigo e descrição, 
//classe item, identificador venda, prop produto,prop quantidade, prop valor,
//classe venda, coleção obj item, função total em quantidade, total em valor.

using System;
using EstudoVendas.Entities;

namespace EstudoVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            var venda = new Venda();
            int n = 2;
            for (int i = 1; i <= n; i++)
            {
                string nomeProduto = "Playstation 5";

                var produto = new Produto(nomeProduto);

                int qtdProduto = 3;
                decimal precoProduto = 4500.00M;

                var item = new Item(qtdProduto, precoProduto, produto);

                venda.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine("Codigo\tDescrição\tValor\tQuantidade\tSubTotal");
            Console.WriteLine(venda);
        }
    }
}
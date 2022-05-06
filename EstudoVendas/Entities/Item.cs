using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVendas.Entities
{
    class Item
    {
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public Produto Produto { get; set; }

        public Item(int quantidade, decimal valor, Produto produto)
        {
            Quantidade = quantidade;
            Valor = valor;
            Produto = produto;
        }
        public decimal SubTotal()
        {
            return Quantidade * Valor;
        }
        public override string ToString()
        {
            var retornoItem = new StringBuilder();
            retornoItem.AppendLine($"{Produto.Codigo}\t{Produto.Descricao}\t${Valor}\t{Quantidade}\t${SubTotal()}");
            
            return retornoItem.ToString();
        }
    }
}

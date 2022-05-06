using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVendas.Entities
{
    class Venda
    {
        public List<Item> ItemsList { get; set; } = new List<Item>();
        public void AddItem(Item items)
        {
            ItemsList.Add(items);
        }
        public void RemoveItem(Item items)
        {
            ItemsList.Remove(items);
        }
        public decimal Total()
        {
            decimal soma = 0.0M;
            foreach (Item items in ItemsList)
            {
                soma += items.SubTotal();
            }
            return soma;
        }
        public override string ToString()
        {
            var retornoVenda = new StringBuilder();
            foreach (Item items in ItemsList)
            {
                retornoVenda.AppendLine(items.ToString());
            }
            retornoVenda.AppendLine($"\t\t\t\t\t Total: ${Total()}");

            return retornoVenda.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public double Preco { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemVenda venda &&
                   Id == venda.Id &&
                   EqualityComparer<Venda>.Default.Equals(Venda, venda.Venda) &&
                   EqualityComparer<Produto>.Default.Equals(Produto, venda.Produto) &&
                   Quantidade == venda.Quantidade &&
                   Desconto == venda.Desconto &&
                   Preco == venda.Preco;
        }

        public override int GetHashCode()
        {
            int hashCode = -1006098578;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Venda>.Default.GetHashCode(Venda);
            hashCode = hashCode * -1521134295 + EqualityComparer<Produto>.Default.GetHashCode(Produto);
            hashCode = hashCode * -1521134295 + Quantidade.GetHashCode();
            hashCode = hashCode * -1521134295 + Desconto.GetHashCode();
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemCompra
    {
        public int Id { get; set; }
        public Compra Compra { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public double Preco { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemCompra compra &&
                   Id == compra.Id &&
                   EqualityComparer<Compra>.Default.Equals(Compra, compra.Compra) &&
                   EqualityComparer<Produto>.Default.Equals(Produto, compra.Produto) &&
                   Quantidade == compra.Quantidade &&
                   Desconto == compra.Desconto &&
                   Preco == compra.Preco;
        }

        public override int GetHashCode()
        {
            int hashCode = -1006098578;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Compra>.Default.GetHashCode(Compra);
            hashCode = hashCode * -1521134295 + EqualityComparer<Produto>.Default.GetHashCode(Produto);
            hashCode = hashCode * -1521134295 + Quantidade.GetHashCode();
            hashCode = hashCode * -1521134295 + Desconto.GetHashCode();
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
    }
}

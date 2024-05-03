using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Compra
    {
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime Instante { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public double ValorTotal { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Compra compra &&
                   Id == compra.Id &&
                   EqualityComparer<Fornecedor>.Default.Equals(Fornecedor, compra.Fornecedor) &&
                   Instante == compra.Instante &&
                   Descricao == compra.Descricao &&
                   Desconto == compra.Desconto &&
                   ValorTotal == compra.ValorTotal;
        }

        public override int GetHashCode()
        {
            int hashCode = -408876678;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Fornecedor>.Default.GetHashCode(Fornecedor);
            hashCode = hashCode * -1521134295 + Instante.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descricao);
            hashCode = hashCode * -1521134295 + Desconto.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorTotal.GetHashCode();
            return hashCode;
        }
    }
}

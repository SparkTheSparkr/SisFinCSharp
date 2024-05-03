using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Instante { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public double ValorTotal { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Venda venda &&
                   Id == venda.Id &&
                   EqualityComparer<Cliente>.Default.Equals(Cliente, venda.Cliente) &&
                   Instante == venda.Instante &&
                   Descricao == venda.Descricao &&
                   Desconto == venda.Desconto &&
                   ValorTotal == venda.ValorTotal;
        }

        public override int GetHashCode()
        {
            int hashCode = 1801122321;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(Cliente);
            hashCode = hashCode * -1521134295 + Instante.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descricao);
            hashCode = hashCode * -1521134295 + Desconto.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorTotal.GetHashCode();
            return hashCode;
        }
    }
}

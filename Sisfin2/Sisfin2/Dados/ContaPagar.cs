using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagar
    {
        public int Id { get; set; }
        public decimal valor { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataRecbimento { get; set; }
        public decimal valorRecebido { get; set; }
        public MeioPagamento meioPagamento { get; set; }
        public EstadoPagamento situacao { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ContaPagar pagar &&
                   Id == pagar.Id &&
                   valor == pagar.valor &&
                   dataCadastro == pagar.dataCadastro &&
                   dataRecbimento == pagar.dataRecbimento &&
                   valorRecebido == pagar.valorRecebido &&
                   meioPagamento == pagar.meioPagamento &&
                   situacao == pagar.situacao;
        }

        public override int GetHashCode()
        {
            int hashCode = 1677816959;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + dataCadastro.GetHashCode();
            hashCode = hashCode * -1521134295 + dataRecbimento.GetHashCode();
            hashCode = hashCode * -1521134295 + valorRecebido.GetHashCode();
            hashCode = hashCode * -1521134295 + meioPagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + situacao.GetHashCode();
            return hashCode;
        }
    }
}

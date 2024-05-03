using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceber
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
            return obj is ContaReceber receber &&
                   Id == receber.Id &&
                   valor == receber.valor &&
                   dataCadastro == receber.dataCadastro &&
                   dataRecbimento == receber.dataRecbimento &&
                   valorRecebido == receber.valorRecebido &&
                   meioPagamento == receber.meioPagamento &&
                   situacao == receber.situacao;
        }

        public override int GetHashCode()
        {
            int hashCode = -1573195681;
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

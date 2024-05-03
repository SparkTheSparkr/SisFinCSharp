using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ControleCaixa
    {
        public int Id { get; set; }
        public decimal valor { get; set; }
        public DateTime data { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ControleCaixa caixa &&
                   Id == caixa.Id &&
                   valor == caixa.valor &&
                   data == caixa.data;
        }

        public override int GetHashCode()
        {
            int hashCode = -107578674;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + data.GetHashCode();
            return hashCode;
        }
    }
}

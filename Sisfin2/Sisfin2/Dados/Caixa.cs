using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Caixa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Caixa caixa &&
                   Id == caixa.Id &&
                   nome == caixa.nome;
        }

        public override int GetHashCode()
        {
            int hashCode = 459441776;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            return hashCode;
        }
    }
}

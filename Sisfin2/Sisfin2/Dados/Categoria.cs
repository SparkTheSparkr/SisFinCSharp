using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Categoria
    {
        public int Id { get; set; }
        public string nome { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Categoria categoria &&
                   Id == categoria.Id &&
                   nome == categoria.nome;
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

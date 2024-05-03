using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Conta
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public TipoConta tipo { get; set; }
        public Categoria categoria { get; set; }
        public bool status { get; set; }


        public override bool Equals(object obj)
        {
            return obj is Conta conta &&
                   Id == conta.Id &&
                   descricao == conta.descricao &&
                   tipo == conta.tipo &&
                   EqualityComparer<Categoria>.Default.Equals(categoria, conta.categoria) &&
                   status == conta.status;
        }

        public override int GetHashCode()
        {
            int hashCode = 926925960;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descricao);
            hashCode = hashCode * -1521134295 + tipo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Categoria>.Default.GetHashCode(categoria);
            hashCode = hashCode * -1521134295 + status.GetHashCode();
            return hashCode;
        }
    }
}

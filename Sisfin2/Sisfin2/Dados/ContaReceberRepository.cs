using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceberRepository
    {
        private IList<ContaReceber> _contasReceber = new List<ContaReceber>();

        public ContaReceber Insert(ContaReceber contaReceber)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._contasReceber.Add(contaReceber);
            return contaReceber;
        }

        public ContaReceber Update(ContaReceber contaReceber)
        {
            this._contasReceber[this._contasReceber.IndexOf(contaReceber)] = contaReceber;
            return contaReceber;
        }

        public void Remove(ContaReceber contaReceber)
        {
            this._contasReceber.Remove(contaReceber);
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _contasReceber;
        }

        public IList<ContaReceber> getAll()
        {
            return _contasReceber;
        }
    }
}

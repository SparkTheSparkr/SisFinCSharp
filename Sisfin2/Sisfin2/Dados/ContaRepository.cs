using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaRepository
    {
        private IList<Conta> _contas = new List<Conta>();

        public Conta Insert(Conta conta)
        {
            // Aqui você poderia inserir a conta em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._contas.Add(conta);
            return conta;
        }

        public Conta Update(Conta conta)
        {
            this._contas[this._contas.IndexOf(conta)] = conta;
            return conta;
        }

        public void Remove(Conta conta)
        {
            this._contas.Remove(conta);
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _contas;
        }

        public IList<Conta> getAll()
        {
            return _contas;
        }
        public IList<Conta> getContaPorCategoriaId(int id)
        {
            return _contas.Where(item => item.categoria.Id == id).ToList();
        }
    }
}

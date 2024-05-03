using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CaixaRepository
    {
        private IList<Caixa> _caixas = new List<Caixa>();

        public Caixa Insert(Caixa caixa)
        {
            // Aqui você poderia inserir a caixa em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._caixas.Add(caixa);
            return caixa;
        }

        public Caixa Update(Caixa caixa)
        {
            this._caixas[this._caixas.IndexOf(caixa)] = caixa;
            return caixa;
        }

        public void Remove(Caixa caixa)
        {
            this._caixas.Remove(caixa);
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _caixas;
        }

        public IList<Caixa> getAll()
        {
            return _caixas;
        }
    }
}

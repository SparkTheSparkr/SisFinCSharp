using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ControleCaixaRepository
    {
        private IList<ControleCaixa> _controlesCaixa = new List<ControleCaixa>();

        public ControleCaixa Insert(ControleCaixa controleCaixa)
        {
            // Aqui você poderia inserir a controleCaixa em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._controlesCaixa.Add(controleCaixa);
            return controleCaixa;
        }

        public ControleCaixa Update(ControleCaixa controleCaixa)
        {
            this._controlesCaixa[this._controlesCaixa.IndexOf(controleCaixa)] = controleCaixa;
            return controleCaixa;
        }

        public void Remove(ControleCaixa controleCaixa)
        {
            this._controlesCaixa.Remove(controleCaixa);
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return _controlesCaixa;
        }

        public IList<ControleCaixa> getAll()
        {
            return _controlesCaixa;
        }
    }
}


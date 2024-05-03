using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ControleCaixaService
    {
        private ControleCaixaRepository _repository;

        public ControleCaixaService()
        {
            _repository = new ControleCaixaRepository();
        }

        public void Insert(int id, decimal valor, DateTime data)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var controleCaixa = new ControleCaixa
            {
                Id = id,
                valor = valor,
                data = data,
            };

            _repository.Insert(controleCaixa);

        }

        public void Insert(ControleCaixa controleCaixa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(controleCaixa);

        }

        public ControleCaixa FindById(int id)
        {
            foreach (ControleCaixa c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<ControleCaixa> getAll()
        {
            return _repository.ObterTodos().ToList<ControleCaixa>();
        }

    }
}

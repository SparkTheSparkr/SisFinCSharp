using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CaixaService
    {
        private CaixaRepository _repository;

        public CaixaService()
        {
            _repository = new CaixaRepository();
        }

        public void Insert(int id, string nome)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var caixa = new Caixa
            {
                Id = id,
                nome = nome,
            };

            _repository.Insert(caixa);

        }

        public void Insert(Caixa caixa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(caixa);

        }

        public Caixa FindById(int id)
        {
            foreach (Caixa c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Caixa> getAll()
        {
            return _repository.ObterTodos().ToList<Caixa>();
        }
    }
}

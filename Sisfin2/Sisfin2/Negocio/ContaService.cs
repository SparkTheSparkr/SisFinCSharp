using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ContaService
    {
        private readonly ContaRepository _repository;

        public ContaService()
        {
            _repository = new ContaRepository();
        }

        public void Insert(int id, string descricao, TipoConta tipo, bool status)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var conta = new Conta
            {
                Id = id,
                descricao = descricao,
                tipo = tipo,
                status = status,
            };

            _repository.Insert(conta);

        }

        public void Insert(Conta conta)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(conta);

        }

        public Conta FindById(int id)
        {
            foreach (Conta c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<Conta> getAll()
        {
            return _repository.ObterTodos().ToList<Conta>();
        }
        public IList<Conta> getContaPorCategoriaId(int id)
        {
            return _repository.getContaPorCategoriaId(id);
        }

    }
}

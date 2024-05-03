using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class FornecedorService
    {
        private FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var fornecedor = new Fornecedor
            {
                Id = id,
                tipoFornecedor = tipoPessoa,
                Nome = nome,
                Email = email
            };

            _repository.Insert(fornecedor);

        }

        public void Insert(Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(fornecedor);

        }

        public Fornecedor FindById(int id)
        {
            foreach (Fornecedor c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Fornecedor> getAll()
        {
            return _repository.ObterTodos().ToList<Fornecedor>();
        }

    }
}

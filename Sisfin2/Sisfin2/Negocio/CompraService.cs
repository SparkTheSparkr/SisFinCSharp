using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CompraService
    {
        private readonly CompraRepository _repository;

        public CompraService()
        {
            _repository = new CompraRepository();
        }

        public void Insert(int id, Fornecedor fornecedor, DateTime instante, string descricao, double desconto, double valorTotal)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var compra = new Compra
            {
                Id = id,
                Fornecedor = fornecedor,
                Instante = instante,
                Descricao = descricao,
                Desconto = desconto,
                ValorTotal = valorTotal
            };

            _repository.Insert(compra);

        }

        public void Insert(Compra compra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(compra);

        }

        public Compra FindById(int id)
        {
            foreach (Compra c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }


        public IEnumerable<Compra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<Compra> getAll()
        {
            return _repository.getAll();
        }

    }
}

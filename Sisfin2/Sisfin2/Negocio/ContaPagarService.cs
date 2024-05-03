using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ContaPagarService
    {
        private readonly ContaPagarRepository _repository;

        public ContaPagarService()
        {
            _repository = new ContaPagarRepository();
        }

        public void Insert(int id, decimal valor, DateTime dataCadastro, DateTime dataRecebimento, decimal valorRecebido, MeioPagamento meioPagamento, EstadoPagamento situacao)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contaPagar = new ContaPagar
            {
                Id = id,
                valor = valor,
                dataCadastro = dataCadastro,
                dataRecbimento = dataRecebimento,
                valorRecebido = valorRecebido,
                meioPagamento = meioPagamento,
                situacao = situacao,
            };

            _repository.Insert(contaPagar);

        }

        public void Insert(ContaPagar contaPagar)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(contaPagar);

        }


        public ContaPagar FindById(int id)
        {
            foreach (ContaPagar c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public ContaPagar FindByContaId(int id)
        {
            foreach (ContaPagar c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<ContaPagar> getAll()
        {
            return _repository.getAll();
        }
    }
}

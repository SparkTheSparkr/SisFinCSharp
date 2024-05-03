using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ContaReceberService
    {
        private readonly ContaReceberRepository _repository;

        public ContaReceberService()
        {
            _repository = new ContaReceberRepository();
        }

        public void Insert(int id, decimal valor, DateTime dataCadastro, DateTime dataRecebimento, decimal valorRecebido, MeioPagamento meioPagamento, EstadoPagamento situacao)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contaReceber = new ContaReceber
            {
                Id = id,
                valor = valor,
                dataCadastro = dataCadastro,
                dataRecbimento = dataRecebimento,
                valorRecebido = valorRecebido,
                meioPagamento = meioPagamento,
                situacao = situacao,
            };

            _repository.Insert(contaReceber);

        }

        public void Insert(ContaReceber contaReceber)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(contaReceber);

        }


        public ContaReceber FindById(int id)
        {
            foreach (ContaReceber c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public ContaReceber FindByContaId(int id)
        {
            foreach (ContaReceber c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<ContaReceber> getAll()
        {
            return _repository.getAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ItemCompraService
    {
        private readonly ItemCompraRepository _repository;

        public ItemCompraService()
        {
            _repository = new ItemCompraRepository();
        }

        public void Insert(int id, Compra compra, Produto produto, double quantidade, double desconto, double preco)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var item = new ItemCompra
            {
                Id = id,
                Compra = compra,
                Produto = produto,
                Quantidade = quantidade,
                Desconto = desconto,
                Preco = preco
            };

            _repository.Insert(item);

        }

        public void Insert(ItemCompra itemCompra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(itemCompra);

        }


        public ItemCompra FindById(int id)
        {
            foreach (ItemCompra c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public ItemCompra FindByCompraId(int id)
        {
            foreach (ItemCompra c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<ItemCompra> getAll()
        {
            return _repository.getAll();
        }

        public IList<ItemCompra> getItensPorCompraId(int id)
        {
            return _repository.getItemsCompraPorCompraId(id);
        }
    }
}

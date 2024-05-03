using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CategoriaRepository
    {
        private IList<Categoria> _categorias = new List<Categoria>();

        public Categoria Insert(Categoria categoria)
        {
            // Aqui você poderia inserir a categoria em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._categorias.Add(categoria);
            return categoria;
        }

        public Categoria Update(Categoria categoria)
        {
            this._categorias[this._categorias.IndexOf(categoria)] = categoria;
            return categoria;
        }

        public void Remove(Categoria categoria)
        {
            this._categorias.Remove(categoria);
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _categorias;
        }

        public IList<Categoria> getAll()
        {
            return _categorias;
        }
    }
}

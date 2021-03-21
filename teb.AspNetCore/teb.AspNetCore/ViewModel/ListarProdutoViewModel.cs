using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teb.AspNetCore.Models;

namespace teb.AspNetCore.ViewModel
{
    public class ListarProdutoViewModel
    {
        public List<Produto> Produtos { get; }
        public List<Categoria> Categorias { get; }

        public ListarProdutoViewModel()
        {
            Produtos = new List<Produto>();

            Categorias = new List<Categoria>();
        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teb.AspNetCore.Data;
using teb.AspNetCore.Models;
using teb.AspNetCore.Repository.Interfaces;

namespace teb.AspNetCore.Repository.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly BarContext _barContext;

        public ProdutoRepository(BarContext barContext)
        {
            _barContext = barContext;
        }

        public Produto CarregarPorId(int id)
        {
            return _barContext.Produtos.Include(c => c.Categoria).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produto> CarregarProdutosPorCategoria(int idCategoria)
        {
            return _barContext.Produtos.Include(c => c.Categoria).Where(p => p.CategoriaId == idCategoria).OrderBy(p => p.Categoria.Nome);
        }

        public IEnumerable<Produto> CarregarTodos()
        {
            return _barContext.Produtos.Include(c => c.Categoria).OrderBy(p => p.QuantidadeEstoque).ToList();
        }
    }
}

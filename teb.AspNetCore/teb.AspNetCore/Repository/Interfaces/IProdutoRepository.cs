using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teb.AspNetCore.Models;

namespace teb.AspNetCore.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> CarregarTodos();

        Produto CarregarPorId(int id);

        IEnumerable<Produto> CarregarProdutosPorCategoria(int idCategoria);
    }
}

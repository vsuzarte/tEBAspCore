using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teb.AspNetCore.Data;
using teb.AspNetCore.Models;
using teb.AspNetCore.Repository.Interfaces;

namespace teb.AspNetCore.Repository.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly BarContext _barContext;

        public CategoriaRepository(BarContext barContext)
        {
            _barContext = barContext;
        }

        public Categoria CarregarPorId(int id)
        {
            return _barContext.Categorias.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Categoria> CarregarTodos()
        {
            return _barContext.Categorias.OrderBy(c => c.Nome).ToList();
        }
    }
}

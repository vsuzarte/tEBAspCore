using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teb.AspNetCore.Models;

namespace teb.AspNetCore.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> CarregarTodos();

        Categoria CarregarPorId(int id);

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teb.AspNetCore.Repository.Interfaces;

namespace teb.AspNetCore.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Cervejas()
        {
            var cervejas = _produtoRepository.CarregarProdutosPorCategoria(idCategoria: 1);

            return View(cervejas);
        }
    }
}

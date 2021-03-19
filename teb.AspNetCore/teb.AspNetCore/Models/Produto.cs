using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teb.AspNetCore.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Imagem { get; set; }

        public string Descricao { get; set; }

        public int QuantidadeEstoque { get; set; }

        public int CategoriaId { get; set; }
        
        public virtual Categoria Categoria { get; set; }

    }
}

using System;

namespace TesteNelson.Domain
{
    public class Produto
    {
        public Produto()
        {
            ProdutoId = Guid.NewGuid();
        }

        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}

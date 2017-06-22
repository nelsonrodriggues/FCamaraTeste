using System.Data.Entity.ModelConfiguration;
using TesteNelson.Domain;

namespace TesteNelson.Infra.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(c => c.ProdutoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Preco)
                .IsRequired();

            ToTable("Produtos");
        }
    }
}

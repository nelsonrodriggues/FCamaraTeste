using TesteNelson.Domain;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using TesteNelson.Infra.Data.Context;

namespace TesteNelson.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TesteNelsonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TesteNelsonContext context)
        {
            context.Produtos.AddRange(new List<Produto> {
                new Produto { Nome = "Impressora Epson", Descricao = "Multifuncional Tanque L395 Wireless", Preco = 855.00m },
                new Produto { Nome = "HD Externo", Descricao = "HD Externo 1TB USB 3.0", Preco = 289.00m },
                new Produto { Nome = "Roteador TP-Link", Descricao = "Roteador TP-Link 150 Mbps Wireless", Preco = 59.90m },
                new Produto { Nome = "Notebook Lenovo", Descricao = "Notebook Lenovo Core i5, 8GB, 1TB", Preco = 2500.00m },
                new Produto { Nome = "Kindle", Descricao = "Kindle Paperwhite com Wifi", Preco = 414.00m },
                new Produto { Nome = "Placa de Video", Descricao = "Placa de Video Nvidia GTForce GTX 1050ti", Preco = 699.00m },
                new Produto { Nome = "Ipod Touch 6 Apple", Descricao = "Ipod Touch 6 Apple 16GB", Preco = 1399.00m }
            });
            context.SaveChanges();
        }
    }
}

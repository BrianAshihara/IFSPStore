
using IFStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
namespace IFSPStore.Teste
{
    [TestClass]
    public class UnitTestRepository
    {
        public class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuario { get; set; }

            public DbSet<Cidade> Cidade { get; set; }

            public DbSet<Cliente> Cliente { get; set; }

            public DbSet<Grupo> Grupo { get; set; }

            public DbSet<Produto> Produto { get; set; }

            public DbSet<Venda> Venda { get; set; }

            public DbSet<VendaItem> VendaItem { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};" + $"Database = {database};Uid={username};Pwd={password}";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestUsuario()
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario
                {
                    Nome = "Brian",
                    Senha = "0",
                    Login = "ash",

                    Email = "brian.ashihara@aluno.ifsp.edu.br",

                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now,
                    Ativo = true

                };
                context.Usuario.Add(usuario);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestCidade()
        {
            using (var context = new MyDbContext())
            {
                var cidade = new Cidade
                {
                    Nome = "Ituiutaba",
                    Estado = "Minas Gerais"

                };
                context.Cidade.Add(cidade);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void TestCliente()
        {
            using (var context = new MyDbContext())
            {
                var cidade = context.Cidade.First(c => c.Id == 1);
                var cliente = new Cliente
                {
                    Nome = "ricksouzaok",
                    Endereco = "nao sei",
                    Documentento = "cpf",
                    Bairro = "vila",
                    Cidade = cidade

                };
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
        }


        [TestMethod]
        public void TestVenda()
        {
            using (var context = new MyDbContext())
            {
                var usuario = context.Usuario.First(b => b.Id == 3);
                var cliente = context.Cliente.First(d => d.Id == 7);
                var venda = new Venda
                {
                    Data = DateTime.Now,
                    ValorTotal = 900,
                    Usuario = usuario,
                    Cliente = cliente
                };
                context.Venda.Add(venda);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void TestSelectVenda()
        {
            using (var context = new MyDbContext())
            {
                foreach (var venda in context.Venda)
                {
                    Console.WriteLine(JsonSerializer.Serialize(venda));
                }
            }
        }

        [TestMethod]
        public void TestSelectProduto()
        {
            using (var context = new MyDbContext())
            {
                foreach (var produto in context.Produto)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }
        [TestMethod]
        public void TestGrupo()
        {
            using (var context = new MyDbContext())
            {
                var grupo = new Grupo
                {
                    Nome = "JOIA"

                };
                context.Grupo.Add(grupo);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestProduto()
        {
            using (var context = new MyDbContext())
            {
                var grupo = context.Grupo.First(a => a.Id == 1);
                var produto = new Produto
                {
                    Nome = "banana",
                    Preco = 200,
                    Quantidade = 1,
                    DataCompra = DateTime.Now,
                    UnidadeVenda = "5",
                    Grupo = grupo
                };
                context.Produto.Add(produto);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void TestSelectGrupo()
        {
            using (var context = new MyDbContext())
            {
                foreach (var grupo in context.Grupo)
                {
                    Console.WriteLine(JsonSerializer.Serialize(grupo));
                }
            }
        }
        [TestMethod]
        public void TestSelectCliente()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Cliente)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }

        [TestMethod]
        public void TestSelectCidade()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cidade in context.Cidade)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }
    }
}




using IFStore.Domain.Entities;
using System.Text.Json;
namespace IFSPStore.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var grupo = new Grupo();
            grupo.Nome = "Local";
            Console.WriteLine(JsonSerializer.Serialize(grupo));
            Assert.AreEqual(grupo.Nome, "Local");

            var venda = new Venda();
            venda.ValorTotal = 10.7;
            Console.WriteLine(JsonSerializer.Serialize(venda));
            Assert.AreEqual(venda.ValorTotal, 10.7);

            var cidade = new Cidade();
            cidade.Nome = "Birigui";
            Console.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Birigui");

            var produto = new Produto();
            produto.Nome = "Garrafa";
            Console.WriteLine(JsonSerializer.Serialize(produto));
            Assert.AreEqual(produto.Nome, "Garrafa");

            var vendaitem = new VendaItem();
            vendaitem.Quantidade = 50;
            Console.WriteLine(JsonSerializer.Serialize(vendaitem));
            Assert.AreEqual(vendaitem.Quantidade, 50);

            var usuario = new Usuario();
            usuario.Nome = "Brian";
            Console.WriteLine(JsonSerializer.Serialize(usuario));
            Assert.AreEqual(usuario.Nome, "Brian");

            var cliente = new Cliente();
            cliente.Nome = "Henrique";
            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Henrique");
        }
    }
}
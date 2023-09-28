
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
            grupo.Nome = "Garrafa";
            Console.WriteLine(JsonSerializer.Serialize(grupo));
            Assert.AreEqual(grupo.Nome, "Garrafa");
        }
    }
}
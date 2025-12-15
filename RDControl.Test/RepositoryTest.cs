using RDControl.Domain.Entities;
using RDControl.Repository.Context;
using System.Text.Json;

namespace RDControl.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestUser()
        {
            using (var context = new RDControlContext())
            {
                Console.WriteLine("Connected!");

                var user1 = new User(1, "Joao", "joao@gmail.com", "SoneJojo", "duda1704", DateTime.Now);

                context.Users.Add(user1);
                context.SaveChanges();
                Console.WriteLine("User Added!");
            }
            using (var context = new RDControlContext())
            {
                foreach (var cat in context.Users)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("List Done!");
            }
        }
    }
}

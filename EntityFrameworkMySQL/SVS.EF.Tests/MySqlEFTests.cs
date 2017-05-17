using NUnit.Framework;
using System;

namespace SVS.EF.Tests
{
    [TestFixture]
    public class MySqlEFTests
    {
        [Test]
        public void GetPostsTest()
        {
            var context = new ContextoBD();

            var posts = context.Posts;

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Id} | {post.Contenido}");
            }
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Sistematic.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var path = @"C:\dev\Frinscal\resource\teste jairo3a.txt";
            Assert.True(File.Exists(path));

            var lines = new List<string>();

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path).ToList();
            }
            Assert.NotEmpty(lines);

            var items = new List<Item>();
            lines.ForEach(x =>
            {
                var filds = x.Split('|');
                var register = filds[1];
                var code = filds[2];
                var description = filds[3];

                if (register == "0200")
                {
                    var item = new Item
                    {
                        Code = code,
                        Description = description
                    };

                    items.Add(item);
                }
            });

            Assert.NotEmpty(items);
        }
    }

    public struct Item
    {
        public string Code { get; init; }
        public string Description { get; init; }
    }
}
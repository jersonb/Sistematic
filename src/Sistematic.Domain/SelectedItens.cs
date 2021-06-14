using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistematic.Domain
{
    public class SelectedItens
    {
        public string ItemsToSelect { get; set; }

        public Task<List<Item>> Select(List<Item> items)
        {
            var itensToSelect = ItemsToSelect.Split("\n").ToList();
            items.ForEach(item =>
            {
                if (itensToSelect.Contains(item.Code))
                {
                    item.Encouraged = true;
                }
            });

            items = items.OrderByDescending(item => item.Encouraged).ToList();
            return Task.FromResult(items);
        }
    }
}
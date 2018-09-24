using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WpfApp1.Models;

namespace WpfApp1.DataServices.Impl
{
    public class FakeUnitDataService : IUnitDataService
    {
        readonly Dictionary<int, Models.Unit> _items = Enumerable
                .Range(1, 100)
                .Select(i => new Models.Unit
                {
                    Id = i,
                    Material = $"Material {i}",
                })
                .ToDictionary(e => e.Id, e => e);

        public async Task<ICollection<Unit>> GetAllAsync()
        {
            await Task.Delay(1500).ConfigureAwait(false);
            return _items
                .Select(e => new Models.Unit
                {
                    Id = e.Key,
                    Material = e.Value.Material,
                })
                .ToList();
        }

        public async Task UpdateAsync(int id, Unit item)
        {
            await Task.Delay(250).ConfigureAwait(false);
            _items[id].Material = item.Material;
        }
    }
}

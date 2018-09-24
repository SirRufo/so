using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfApp1.DataServices
{
    public interface IUnitDataService
    {
        Task<ICollection<Models.Unit>> GetAllAsync();
        Task UpdateAsync(int id, Models.Unit item);
    }
}

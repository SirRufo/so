using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WPFAsyncProcess.Models;

namespace WPFAsyncProcess.Services.Fake
{
    public class FakeFileProcessor : IFileProcessor
    {
        public async Task<ICollection<LogLine>> ProcessFilesAsync()
        {
            await Task.Delay(2500).ConfigureAwait(false);
            return Enumerable.Range(1, 1000).Select(e => new LogLine { Value = e.ToString(), }).ToList();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

using WPFAsyncProcess.Models;

namespace WPFAsyncProcess.Services
{
    public interface IFileProcessor
    {
        Task<ICollection<LogLine>> ProcessFilesAsync();
    }
}

using System.Threading.Tasks;

namespace BusyIndicator.Services
{
    public interface IFooService
    {
        Task DoSomeWorkAsync(bool continueOnCapturedContext);
    }
}

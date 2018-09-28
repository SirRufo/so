using System.Threading.Tasks;

namespace BusyIndicator.Services
{
    public interface IAsyncInitialization
    {
        Task InitializeAsync(object parameter);
    }

    public interface IFooService : IAsyncInitialization
    {
        Task DoSomeWorkAsync(bool continueOnCapturedContext);
    }
}

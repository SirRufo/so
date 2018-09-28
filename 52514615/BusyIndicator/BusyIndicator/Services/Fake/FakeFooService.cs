using System.Threading;
using System.Threading.Tasks;

namespace BusyIndicator.Services.Fake
{
    public class FakeFooService : IFooService
    {
        public async Task DoSomeWorkAsync(bool continueOnCapturedContext)
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(250).ConfigureAwait(continueOnCapturedContext);
                Thread.Sleep(250);
            }
        }

        public Task InitializeAsync(object parameter)
        {
            return Task.Delay(250);
        }
    }
}

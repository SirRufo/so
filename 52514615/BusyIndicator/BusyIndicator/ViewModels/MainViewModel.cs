using ReactiveUI;

using System.Threading.Tasks;
using System.Windows.Input;

namespace BusyIndicator.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        public ICommand ReloadDataCommand => ReactiveCommand.CreateFromTask(ReloadDataAsync);

        private Task ReloadDataAsync()
        {
            return LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            IsBusy = true;
            await Task.Delay(1500);
            IsBusy = false;
        }

        public override Task InitializeAsync(object parameter)
        {
            return LoadDataAsync();
        }
    }
}

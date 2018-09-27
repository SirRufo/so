using BusyIndicator.Utils;

using ReactiveUI;

using System.Threading.Tasks;

namespace BusyIndicator.ViewModels.Base
{
    public abstract class ViewModelBase : ObservableObject
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }

        public virtual Task InitializeAsync(object parameter)
        {
            return Task.CompletedTask;
        }
    }
}

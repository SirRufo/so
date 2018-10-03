using ReactiveUI;

using System.Threading.Tasks;

namespace WPFAsyncProcess.ViewModels.Base
{
    public abstract class ViewModelBase : ReactiveObject
    {
        bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            protected set => this.RaiseAndSetIfChanged(ref isBusy, value);
        }

        public virtual Task InitializeAsync(object parameter)
        {
            return Task.CompletedTask;
        }
    }
}

using System.Threading.Tasks;

using WpfApp1.Utils;

namespace WpfApp1.ViewModels.Base
{
    public abstract class ViewModelBase : BindableObject
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            protected set => Set(ref _isBusy, value);
        }

        public virtual Task InitializeAsync(object parameter)
        {
            return Task.CompletedTask;
        }
    }
}

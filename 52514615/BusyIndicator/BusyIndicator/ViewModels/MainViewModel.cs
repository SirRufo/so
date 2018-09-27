using BusyIndicator.Services;

using ReactiveUI;

using System.Threading.Tasks;
using System.Windows.Input;

namespace BusyIndicator.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        private bool _continueOnCapturedContext;
        private readonly IFooService _fooService;

        public MainViewModel(IFooService fooService)
        {
            _fooService = fooService ?? throw new System.ArgumentNullException(nameof(fooService));
        }

        public bool ContinueOnCapturedContext
        {
            get => _continueOnCapturedContext;
            set => this.RaiseAndSetIfChanged(ref _continueOnCapturedContext, value);
        }
        public ICommand ReloadDataCommand => ReactiveCommand.CreateFromTask(ReloadDataAsync);

        private Task ReloadDataAsync()
        {
            return LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            IsBusy = true;
            await _fooService.DoSomeWorkAsync(ContinueOnCapturedContext);
            IsBusy = false;
        }

        public override Task InitializeAsync(object parameter)
        {
            return LoadDataAsync();
        }
    }
}

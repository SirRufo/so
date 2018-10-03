using ReactiveUI;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

using WPFAsyncProcess.Models;
using WPFAsyncProcess.Services;

namespace WPFAsyncProcess.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        private readonly IFileProcessor _fileProcessor;

        public MainViewModel(IFileProcessor fileProcessor)
        {
            _fileProcessor = fileProcessor ?? throw new System.ArgumentNullException(nameof(fileProcessor));
        }

        private ObservableCollection<LogLine> _logLines;

        public ICollection<LogLine> LogLines
        {
            get => _logLines != null ? new ReadOnlyObservableCollection<LogLine>(_logLines) : null;
            set
            {
                var val = value != null ? new ObservableCollection<LogLine>(value) : null;
                this.RaiseAndSetIfChanged(ref _logLines, val);
            }
        }

        public ICommand ProcessFilesCommand => ReactiveCommand.CreateFromTask(ProcessFilesCommandExecuteAsync);

        private async Task ProcessFilesCommandExecuteAsync()
        {
            IsBusy = true;
            LogLines = await _fileProcessor.ProcessFilesAsync();
            IsBusy = false;
        }

        public override Task InitializeAsync(object parameter)
        {
            return ProcessFilesCommandExecuteAsync();
        }
    }
}

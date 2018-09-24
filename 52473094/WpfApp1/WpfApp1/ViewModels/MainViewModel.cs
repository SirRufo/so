using ReactiveUI;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using WpfApp1.DataServices;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        private readonly IUnitDataService _unitDataService;
        private ICollection<Models.Unit> _objects;
        private Unit _selectedObject;

        public MainViewModel(IUnitDataService unitDataService)
        {
            _unitDataService = unitDataService ?? throw new System.ArgumentNullException(nameof(unitDataService));
        }

        public ICollection<Models.Unit> Objects
        {
            get => _objects;
            private set => this.RaiseAndSetIfChanged(ref _objects, value);
        }

        public Models.Unit SelectedObject
        {
            get => _selectedObject;
            set => this.RaiseAndSetIfChanged(ref _selectedObject, value);
        }

        public ICommand UpdateObject => ReactiveCommand.CreateFromTask<Models.Unit>(UpdateObjectExecute);

        private async Task UpdateObjectExecute(Models.Unit o)
        {
            IsBusy = true;
            await _unitDataService.UpdateAsync(o.Id, o);
            IsBusy = false;
        }

        private async Task LoadDataAsync()
        {
            IsBusy = true;
            var items = await _unitDataService.GetAllAsync();
            Objects = new ObservableCollection<Models.Unit>(items);
            SelectedObject = Objects.FirstOrDefault();
            IsBusy = false;
        }

        public override Task InitializeAsync(object parameter)
        {
            return LoadDataAsync();
        }
    }
}

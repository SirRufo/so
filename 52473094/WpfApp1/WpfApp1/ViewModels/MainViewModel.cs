using ReactiveUI;

using System.Collections.Generic;

using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        private ICollection<Models.Unit> _objects;
        private Unit _selectedObject;

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
    }
}

using ReactiveUI;

namespace WpfApp1.Models
{
    public class Unit : ReactiveObject
    {
        private int _id;
        private string _material;

        public int Id
        {
            get => _id;
            set => this.RaiseAndSetIfChanged(ref _id, value);
        }
        public string Material
        {
            get => _material;
            set => this.RaiseAndSetIfChanged(ref _material, value);
        }
    }
}

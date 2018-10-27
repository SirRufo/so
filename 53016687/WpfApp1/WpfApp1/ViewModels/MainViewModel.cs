namespace WpfApp1.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        private bool _quickProcess;
        public bool QuickProcess
        {
            get => _quickProcess;
            set
            {
                if (Set(ref _quickProcess, value))
                {
                    RaisePropertyChanged(nameof(UploadToYoutube));
                    RaisePropertyChanged(nameof(UploadToYoutubeEnabled));
                }
            }
        }

        private bool _uploadToYoutube;
        public bool UploadToYoutube
        {
            get => QuickProcess ? false : _uploadToYoutube;
            set => Set(ref _uploadToYoutube, value);
        }

        public bool UploadToYoutubeEnabled
        {
            get => !QuickProcess;
        }
    }
}

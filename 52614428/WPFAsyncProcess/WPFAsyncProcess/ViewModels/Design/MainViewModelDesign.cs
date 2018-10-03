using System.Linq;

using WPFAsyncProcess.Services.Fake;

namespace WPFAsyncProcess.ViewModels.Design
{
    public class MainViewModelDesign : MainViewModel
    {
        public MainViewModelDesign() : base(new FakeFileProcessor())
        {
            LogLines = Enumerable.Range(1, 10).Select(e => new Models.LogLine { Value = e.ToString(), }).ToList();
        }
    }
}

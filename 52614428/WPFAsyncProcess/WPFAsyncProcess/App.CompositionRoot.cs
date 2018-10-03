using System;
using System.Threading.Tasks;

using Unity;
using WPFAsyncProcess.Services;
using WPFAsyncProcess.Services.Fake;
using WPFAsyncProcess.ViewModels;
using WPFAsyncProcess.Views;

namespace WPFAsyncProcess
{
    public partial class App
    {
        class CompositionRoot
        {
            private readonly App _app;
            private readonly Lazy<IUnityContainer> _container = new Lazy<IUnityContainer>(() =>
            {
                var c = new UnityContainer();
                RegisterServices(c);
                return c;
            });

            private static void RegisterServices(IUnityContainer c)
            {
                c.RegisterSingleton<IFileProcessor, FakeFileProcessor>();
            }

            public CompositionRoot(App app)
            {
                _app = app ?? throw new System.ArgumentNullException(nameof(app));
            }

            public async Task InitializeAsync()
            {
                var mainVM = _container.Value.Resolve<MainViewModel>();
                var mainView = new MainWindow
                {
                    DataContext = mainVM,
                };
                _app.MainWindow = mainView;

                await Task.Yield();

                mainView.Show();
                await mainVM.InitializeAsync(null);
            }
        }
    }
}

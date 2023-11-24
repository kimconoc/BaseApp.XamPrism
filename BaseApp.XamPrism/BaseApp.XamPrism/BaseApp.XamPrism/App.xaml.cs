using BaseApp.XamPrism.ServiceProvider;
using BaseApp.XamPrism.ServiceProvider.Interface;
using BaseApp.XamPrism.ViewModels;
using BaseApp.XamPrism.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BaseApp.XamPrism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();

            //Đăng ký interface triển khai DI 
            containerRegistry.Register<IProvider, Provider>();
        }
    }
}

using BaseApp.XamPrism.Constant;
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

        public static string CurrentLanguage = Settings.CurrentLanguage;

        protected override async void OnInitialized()
        {
            InitializeComponent();
            //Đăng kí sử dụng Syncfusion
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDY1MDY5QDMxMzkyZTMyMmUzMGRhbHY5MHVhQVhUeEZBR2E5dTVWSDdtVFpXaG1jT0xiTzNLQ2VUQTBBMEk9");

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("LoginPage");
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>("MainPage");

            //Đăng ký interface triển khai DI 
            containerRegistry.Register<IProvider, Provider>();
        }
    }
}

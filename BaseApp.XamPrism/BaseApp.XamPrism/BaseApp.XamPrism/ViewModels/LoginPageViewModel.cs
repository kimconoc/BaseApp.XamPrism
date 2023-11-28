using BaseApp.XamPrism.DependencyServices;
using BaseApp.XamPrism.Helpers;
using BaseApp.XamPrism.Resources;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseApp.XamPrism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public ICommand LoginCommand => new DelegateCommand(() =>
        {
            ExecuteLogin();
        });
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tính Nhanh 24/7";
        }

        private void ExecuteLogin()
        {
            SafeExecute(async () =>
            {
                using (new UsageHUDService(CommonResource.Common_Message_Processing))
                {
                    DisplayMessage.ShowToast("Xin chào!");
                    return;
                }
            });
        }

    }
}

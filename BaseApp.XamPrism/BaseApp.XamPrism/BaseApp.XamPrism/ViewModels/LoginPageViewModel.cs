using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

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
                DisplayMessage.ShowToast("Xin chào!");
                return;
            });
        }

    }
}

using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApp.XamPrism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tính Nhanh 24/7";
        }
    }
}

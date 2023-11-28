using BaseApp.XamPrism.DependencyServices.DisplayMessageService.Interfaces;
using Prism;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.XamPrism.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }
        protected IDisplayMessage DisplayMessage { get; private set; }

        private bool isBusy = false;
        public bool IsBusy 
        { 
            get => isBusy; 
            set => SetProperty(ref isBusy, value); 
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            if (navigationService == null)
            {
                NavigationService = PrismApplicationBase.Current.Container.Resolve<INavigationService>();
            }
            else 
            { NavigationService = navigationService; }

            DisplayMessage = PrismApplicationBase.Current.Container.Resolve<IDisplayMessage>();
        }

        protected async void SafeExecute(Func<Task> func)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await func?.Invoke();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                IsBusy = false;
            }
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}

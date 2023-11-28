using BaseApp.XamPrism.DependencyServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaseApp.XamPrism.Helpers
{
    public class UsageHUDService : IDisposable
    {
        public UsageHUDService(string message = "")
        {
            StartHUD(message);
        }

        private async void StartHUD(string message)
        {
            await Task.Delay(100);
            DependencyService.Get<IHUDProvider>().DisplayProgress(message);
        }

        public void Dispose()
        {
            DependencyService.Get<IHUDProvider>().Dismiss();
        }
    }
}

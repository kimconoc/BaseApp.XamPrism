using BaseApp.XamPrism.DependencyServices;
using BaseApp.XamPrism.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(HUDService))]

namespace BaseApp.XamPrism.Droid.DependencyServices
{
    //Using AndHUD Version=1.4.3.0
    public class HUDService : IHUDProvider
    {
        public void DisplayProgress(string message)
        {
            AndroidHUD.AndHUD.Shared.Show(Forms.Context, message);
        }

        public void Dismiss()
        {
            AndroidHUD.AndHUD.Shared.Dismiss(Forms.Context);
        }
    }
}
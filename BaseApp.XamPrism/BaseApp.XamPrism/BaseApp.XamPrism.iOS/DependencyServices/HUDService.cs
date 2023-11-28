using BaseApp.XamPrism.DependencyServices;
using BaseApp.XamPrism.iOS.DependencyServices;
using BigTed;
using Xamarin.Forms;

[assembly: Dependency(typeof(HUDService))]

namespace BaseApp.XamPrism.iOS.DependencyServices
{
    //using BTProgressHUD Version =1.3.0.0
    public class HUDService : IHUDProvider
    {
        public void DisplayProgress(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                BTProgressHUD.Show(null, -1, ProgressHUD.MaskType.Black);
            }
            else
            {
                BTProgressHUD.Show(message, -1, ProgressHUD.MaskType.Black);
            }
        }

        public void Dismiss()
        {
            BTProgressHUD.Dismiss();
        }
    }
}
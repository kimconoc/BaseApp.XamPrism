using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaseApp.XamPrism.DependencyServices
{
    public interface IHUDProvider
    {
        void DisplayProgress(string message);

        void Dismiss();
    }
}

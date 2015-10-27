using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AppTestForFastMapper.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Inicialização das configurações do AutoMapper.
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.AutomapperInit();

            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
            #if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
            #endif

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}


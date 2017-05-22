using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;

namespace DesktopAuthentication {
    public partial class App : Application {
        //Below is the clientId of your app registration. 
        //You have to replace the below with the Application Id for your app registration
        private static string ClientId = "50dff152-0882-4fc8-a8c9-1e77b132c3ff";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);
    }
}
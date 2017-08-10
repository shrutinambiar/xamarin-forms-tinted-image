using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Demo.CrossPlatformTintedImage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var rootPage = new MainPage();
            MainPage = new NavigationPage(rootPage) { BarBackgroundColor = Color.Silver, BarTextColor = Color.Black };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

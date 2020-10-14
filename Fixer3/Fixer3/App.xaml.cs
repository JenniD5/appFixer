using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fixer3
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage (new login1());
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new login1());
            }
            if (IsUserLoggedIn == true)
            {
                MainPage = new HomePage2();
                //App.Current.MainPage = new MainPage();

            }

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

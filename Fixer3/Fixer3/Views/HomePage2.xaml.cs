using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixer3.Models;
using Fixer3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fixer3
{
    [DesignTimeVisible(false)]
    public partial class HomePage2 : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public HomePage2()
        {
            InitializeComponent();
            App.IsUserLoggedIn = true;
            SetValue(NavigationPage.HasNavigationBarProperty, false);

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {

                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.Notifications:
                        MenuPages.Add(id, new NavigationPage(new NotificationsPage()));
                        break;
                    case (int)MenuItemType.Mensajes:
                        MenuPages.Add(id, new NavigationPage(new MensajesPage()));
                        break;
                    case (int)MenuItemType.Intereses:
                        MenuPages.Add(id, new NavigationPage(new InteresesPage()));
                        break;
                    case (int)MenuItemType.Configuracion:
                        MenuPages.Add(id, new NavigationPage(new ConfiguracionPage()));
                        break;

                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixer3.Models;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fixer3.Views
{
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {

        HomePage2 RootPage { get => Application.Current.MainPage.Navigation.NavigationStack[2] as HomePage2; }

        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            App.IsUserLoggedIn = true;





            menuItems = new List<HomeMenuItem>
            {

                new HomeMenuItem {Id = MenuItemType.Home, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Notifications, Title="Notificaciones" },
                new HomeMenuItem {Id = MenuItemType.Mensajes, Title="Mensajes" },
                new HomeMenuItem {Id = MenuItemType.Intereses, Title="Intereses" },
                new HomeMenuItem {Id = MenuItemType.Configuracion, Title="Configuracion" }

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}
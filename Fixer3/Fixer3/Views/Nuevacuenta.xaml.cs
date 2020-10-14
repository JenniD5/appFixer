using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fixer3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nuevacuenta : ContentPage
    {
        public Nuevacuenta()
        {
            InitializeComponent();
        }
        private async void Crear_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new MainPage());
            Navigation.NavigationStack.ToList().Clear();
            await Navigation.PushAsync(new HomePage2());
        }
    }
}
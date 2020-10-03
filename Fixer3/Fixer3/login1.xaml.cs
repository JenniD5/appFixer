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
    public partial class login1 : ContentPage
    {
        public login1()
        {
            InitializeComponent();
        }

        private void Entrada_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Btncrearnuevacuenta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nuevacuenta());
        }
    }
}
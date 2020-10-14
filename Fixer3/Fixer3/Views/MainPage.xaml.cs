using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fixer3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new login1());
           
        }

        public async void Inicio_Clicked(object sender, EventArgs e)
        {
            Navigation.NavigationStack.ToList().Clear();
            await Navigation.PushAsync(new HomePage2());
           
        }

        private void BtnCrearcuenta_Clicked(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToSecondPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
        private async void OnNavigateToPage1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
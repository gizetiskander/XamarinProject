using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signin : ContentPage
    {
        public Signin()
        {
            InitializeComponent();
        }

        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        private async void SignIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Projects());
        }
    }
}
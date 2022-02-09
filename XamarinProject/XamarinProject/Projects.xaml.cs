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
    public partial class Projects : ContentPage
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void ProjectList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new Project1());
        }
    }
}
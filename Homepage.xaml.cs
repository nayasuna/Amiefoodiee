using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amiefoodiee
{
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Btnplus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());
        }

        private void Btnprofile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProfile());
        }
        private void BtnFries_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage2());
        }
    }
}
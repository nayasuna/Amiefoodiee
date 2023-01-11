using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace Amiefoodiee
{
    public partial class MyProfile : ContentPage
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Btnorderhistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderHistory());
        }
        private void Btnlanguage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Language());
        }
        private void Btnmyaddress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyAddress());
        }
    }
}

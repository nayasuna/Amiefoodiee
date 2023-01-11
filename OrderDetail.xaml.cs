using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amiefoodiee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetail : ContentPage
    {
        public OrderDetail() => InitializeComponent();

        private void Btnpayment_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Payment());
        }
        private void Btnordernow_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InProgress());
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinShareExemplo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnShareText_Clicked(object sender, System.EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = entryTexto.Text,
                Title = "Deseja compartilhar o Texto com"
            });
        }

        async void btnShareUrl_Clicked(object sender, System.EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = entryUrl.Text,
                Title = "Deseja compartilhar a Url com"
            });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictoApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeportesPage : ContentPage
    {
        public DeportesPage()
        {
            InitializeComponent();
        }

        private async void BtnNatacion_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Natación");
        }

        private async void BtnFutbol_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fútbol");
        }

        private async void BtnTenis_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tenis");
        }

        private async void BtnBasketball_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Basketball");
        }

        private async void BtnCiclismo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ciclismo");
        }
    }
}
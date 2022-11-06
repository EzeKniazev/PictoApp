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
    public partial class AccionesPage : ContentPage
    {
        public AccionesPage()
        {
            InitializeComponent();
        }

        private async void BtnTomarAgua_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero tomar Agua");
        }

        private async void BtnComer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero comer");
        }

        private async void BtnDormir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero dormir");
        }

        private async void BtnElegir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Eso es verdadero");
        }

        private async void BtnEscucharMusica_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero escuchar música");
        }

        private async void BtnHacerCaca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero hacer caca");
        }

        private async void BtnHacerPis_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero hacer pis");
        }

        private async void BtnMirar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mirar");
        }

        private async void BtnMirarTelevision_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero mirar televisión");
        }

        private async void BtnOrdenar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Me ayudas a ordenar?");
        }

        private async void BtnPintar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero pintar");
        }

        private async void BtnSentarse_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero sentarme");
        }
    }
}
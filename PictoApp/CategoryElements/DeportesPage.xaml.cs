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
        private async void BtnHockey_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hockey");
        }
        private async void BtnBoxeo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Boxeo");
        }
        private async void BtnPadel_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Padel");
        }
        private async void BtnHandbol_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Handbol");
        }
        private async void BtnSurf_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Surf");
        }
        private async void BtnGolf_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Golf");
        }
        private async void BtnPingPong_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ping-Pong");
        }
        private async void BtnAjedrez_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ajedrez");
        }
        private async void BtnCorrer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Correr");
        }
        private async void BtnVoleibol_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Voleibol");
        }
        private async void BtnBocha_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Bocha");
        }
    }
}
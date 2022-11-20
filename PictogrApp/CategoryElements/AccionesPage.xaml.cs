using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements
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
            await TextToSpeech.SpeakAsync("Quiero Tomar Agua");
        }
        private async void BtnTomarJugo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Tomar Jugo");
        }
        private async void BtnHacerCaca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Hacer Caca");
        }
        private async void BtnHacerPis_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Hacer Pis");
        }
        private async void BtnMirar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Mirar");
        }
        private async void BtnMirarTele_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Mirar Tele");
        }
        private async void BtnMeAyudas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Me Ayudas a Ordenar?");
        }
        private async void BtnQuieroDormir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Dormir");
        }
        private async void BtnQuieroComer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Comer");
        }
        private async void BtnQuieroPintar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Pintar");
        }
        private async void BtnQuieroEscuchar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Escuchar Música");
        }
        private async void BtnQuieroSilencio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Puedes Hacer Silencio?");
        }
        private async void BtnQuieroSentarme_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Sentarme");
        }
        private async void BtnDondeEsta_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Donde Esta?");
        }
        private async void BtnVerdad_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Eso es Verdad");
        }
        private async void BtnMentira_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Eso es Mentira");
        }
        private async void BtnPuedoJugar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Puedo Jugar?");
        }
        private async void BtnPuedoTocarlo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Puedo Tocar Eso?");
        }
        private async void BtnYoLoLlevo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Yo lo Llevo");
        }
    }
}
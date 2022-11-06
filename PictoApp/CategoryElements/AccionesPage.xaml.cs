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

        private async void TomarAgua_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero tomar Agua");
        }

        private async void Comer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero comer");
        }

        private async void Dormir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero dormir");
        }

        private async void Elegir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Eso es verdadero");
        }

        private async void EscucharMusica_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero escuchar musica");
        }

        private async void HacerCaca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero hacer caca");
        }

        private async void HacerPis_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero hacer pis");
        }

        private async void Mirar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mirar");
        }

        private async void MirarTelevision_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero mirar television");
        }

        private async void Ordenar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Me ayudas a ordenar?");
        }

        private async void Pintar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero pintar");
        }

        private async void Sentarse_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero sentarme");
        }
    }
}
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
    public partial class JuguetesPage : ContentPage
    {
        public JuguetesPage()
        {
            InitializeComponent();
        }

        private async void BtnAutito_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con los Autitos");
        }

        private async void BtnBloques_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con los bloques");
        }

        private async void BtnConsolaDeVideojuegos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar videojuegos");
        }

        private async void BtnCrayones_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar los crayones");
        }

        private async void BtnLibro_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero leer");
        }

        private async void BtnJuegosDeMesa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar un juego de mesa");
        }

        private async void BtnJuguetes_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar los juguetes");
        }

        private async void BtnLapices_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar los lápices");
        }

        private async void BtnMuneca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con la muñecas");
        }

        private async void BtnConstruir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero construir");
        }

        private async void BtnPelota_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con la pelota");
        }

        private async void BtnPinturas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar las pinturas");
        }

        private async void BtnPlastina_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con la plastilina");
        }

        private async void BtnPuzzle_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero armar un puzzle");
        }

        private async void BtnTablet_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar en la tablet");
        }
    }
}
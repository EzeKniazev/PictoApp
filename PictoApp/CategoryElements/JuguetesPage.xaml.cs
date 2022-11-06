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
    public partial class JuguetesPage : ContentPage
    {
        public JuguetesPage()
        {
            InitializeComponent();
        }

        private async void Autito_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con los Autitos");
        }

        private async void Bloques_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con los bloques");
        }

        private async void ConsolaDeVideojuegos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar videojuegos");
        }

        private async void Crayones_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar los crayones");
        }

        private async void Libro_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero leer");
        }

        private async void JuegosDeMesa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar un juego de mesa");
        }

        private async void Juguetes_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar los juguetes");
        }

        private async void Lapices_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar los lápices");
        }

        private async void Muneca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con la muñecas");
        }

        private async void Construir_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero construir");
        }

        private async void Pelota_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con la pelota");
        }

        private async void Pinturas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero usar las pinturas");
        }

        private async void Plastina_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar con la plastilina");
        }

        private async void Puzzle_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero armar un puzzle");
        }

        private async void Tablet_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero jugar en la tablet");
        }
    }
}
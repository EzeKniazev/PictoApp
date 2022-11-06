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

        private async void Natacion_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Natación");
        }

        private async void Futbol_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fútbol");
        }

        private async void Tenis_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tenis");
        }

        private async void Basketball_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Basketball");
        }

        private async void Ciclismo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ciclismo");
        }
    }
}
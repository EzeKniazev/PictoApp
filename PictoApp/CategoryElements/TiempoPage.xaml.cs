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
    public partial class TiempoPage : ContentPage
    {
        public TiempoPage()
        {
            InitializeComponent();
        }
        private async void Dia_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Es de día");
        } 

        private async void Noche_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Es de noche");
        }

        private async void Amanecer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Amanecer");
        }

        private async void Atardecer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Atardecer");
        }

        private async void Hoy_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hoy");
        }

        private async void FinDeSemana_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fin de semana");
        }
    }
}
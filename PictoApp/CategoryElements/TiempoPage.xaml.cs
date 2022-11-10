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
    public partial class TiempoPage : ContentPage
    {
        public TiempoPage()
        {
            InitializeComponent();
        }
        private async void BtnDia_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Es de día");
        } 

        private async void BtnNoche_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Es de noche");
        }

        private async void BtnAmanecer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Amanecer");
        }

        private async void BtnAtardecer_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Atardecer");
        }

        private async void BtnHoy_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hoy");
        }

        private async void BtnFinDeSemana_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fin de semana");
        }
    }
}
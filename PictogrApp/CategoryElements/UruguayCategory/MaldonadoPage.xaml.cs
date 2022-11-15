using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements.UruguayCategory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaldonadoPage : ContentPage
    {
        public MaldonadoPage()
        {
            InitializeComponent();
        }
        private async void BtnMaldonadoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Castillo pittamiglio");
        }

        private async void BtnMaldonadoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mirador punta ballena");
        }

        private async void BtnMaldonadoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo del mar");
        }

        private async void BtnMaldonadoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza portezuelo");
        }

        private async void BtnMaldonadoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Puente laguna garzon");
        }
    }
}
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
    public partial class RochaPage : ContentPage
    {
        public RochaPage()
        {
            InitializeComponent();
        }
        private async void BtnRochaA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fortaleza santa teresa");
        }

        private async void BtnRochaB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Monte de ombues");
        }

        private async void BtnRochaC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Playa grande");
        }

        private async void BtnRochaD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Playa la moza");
        }

        private async void BtnRochaE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Punta del diablo");
        }
    }
}
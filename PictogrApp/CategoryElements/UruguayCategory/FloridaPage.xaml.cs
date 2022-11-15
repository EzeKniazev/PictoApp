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
    public partial class FloridaPage : ContentPage
    {
        public FloridaPage()
        {
            InitializeComponent();
        }
        private async void BtnFloridaA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Capilla san cono");
        }

        private async void BtnFloridaB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Catedral de florida");
        }

        private async void BtnFloridaC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Laindia somos naturaleza");
        }

        private async void BtnFloridaD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Parque robania");
        }

        private async void BtnFloridaE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Prado piedra alta");
        }
    }
}
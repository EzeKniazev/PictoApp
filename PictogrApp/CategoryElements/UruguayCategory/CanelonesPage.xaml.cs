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
    public partial class CanelonesPage : ContentPage
    {
        public CanelonesPage()
        {
            InitializeComponent();
        }
         private async void BtnCanelonesA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Balneario argentino");
        }

        private async void BtnCanelonesB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Cuchilla alta");
        }

        private async void BtnCanelonesC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fonto santa rosa");
        }

        private async void BtnCanelonesD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Pizzorno family estates");
        }

        private async void BtnCanelonesE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Viña varela zarranz");
        }
    }
}
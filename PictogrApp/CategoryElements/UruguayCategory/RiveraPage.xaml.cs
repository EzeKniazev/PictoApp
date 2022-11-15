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
    public partial class RiveraPage : ContentPage
    {
        public RiveraPage()
        {
            InitializeComponent();
        }
        private async void BtnRiveraA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Autodromo eduardo cabrera");
        }

        private async void BtnRiveraB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Parque gran bretaña");
        }

        private async void BtnRiveraC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza flores");
        }

        private async void BtnRiveraD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza internacional");
        }

        private async void BtnRiveraE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Valle de lunarejo");
        }
    }
}
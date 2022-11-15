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
    public partial class PaysanduPage : ContentPage
    {
        public PaysanduPage()
        {
            InitializeComponent();
        }
        private async void BtnPaysanduA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Casa de cultura");
        }

        private async void BtnPaysanduB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Obelisco");
        }

        private async void BtnPaysanduC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Playa de paysandu");
        }

        private async void BtnPaysanduD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Shopping terminal");
        }

        private async void BtnPaysanduE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Termas de guaviyu");
        }
    }
}
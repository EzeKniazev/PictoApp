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
    public partial class DuraznoPage : ContentPage
    {
        public DuraznoPage()
        {
            InitializeComponent();
        }
        private async void BtnDuraznoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Agua clara");
        }

        private async void BtnDuraznoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Bioparque washington");
        }

        private async void BtnDuraznoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Gruta de reyles");
        }

        private async void BtnDuraznoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Iglesia san pedro");
        }

        private async void BtnDuraznoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo historico");
        }
    }
}
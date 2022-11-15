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
    public partial class TreintaYTresPage : ContentPage
    {
        public TreintaYTresPage()
        {
            InitializeComponent();
        }
        private async void BtnTreintaYTresA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Arco bicentenario de artigas");
        }

        private async void BtnTreintaYTresB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Aventura nativa");
        }

        private async void BtnTreintaYTresC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Obelisco fundadores");
        }

        private async void BtnTreintaYTresD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza 19 de abril");
        }

        private async void BtnTreintaYTresE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quebrada de los cuervos");
        }
    }
}
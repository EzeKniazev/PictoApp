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
    public partial class SanJosePage : ContentPage
    {
        public SanJosePage()
        {
            InitializeComponent();
        }
        private async void BtnSanJoseA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Catedral san josé de mayo");
        }

        private async void BtnSanJoseB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo departamental de san josé");
        }

        private async void BtnSanJoseC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Peatonal de san josé");
        }

        private async void BtnSanJoseD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Sierras de mahoma");
        }

        private async void BtnSanJoseE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Teatro baccio");
        }
    }
}
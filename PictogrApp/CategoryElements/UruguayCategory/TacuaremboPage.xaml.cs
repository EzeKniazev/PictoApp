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
    public partial class TacuaremboPage : ContentPage
    {
        public TacuaremboPage()
        {
            InitializeComponent();
        }
        private async void BtnTacuaremboA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Gruta de los helechos");
        }

        private async void BtnTacuaremboB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo carlos gardel");
        }

        private async void BtnTacuaremboC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo de artes visuales");
        }

        private async void BtnTacuaremboD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo del indio y del gaucho escobar");
        }

        private async void BtnTacuaremboE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Pozo hondo");
        }
    }
}
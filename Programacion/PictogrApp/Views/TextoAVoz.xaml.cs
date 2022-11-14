using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextoAVoz : ContentPage
    {
        public TextoAVoz()
        {
            InitializeComponent();
        }

        private async void BtnSpeech_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(TxtSpeech.Text);
        }
    }
}
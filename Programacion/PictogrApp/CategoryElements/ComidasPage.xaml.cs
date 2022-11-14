using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComidasPage : ContentPage
    {
        public ComidasPage()
        {
            InitializeComponent();
        }
        private async void BtnAgua_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Agua");
        }
        #region Dulces
        private async void BtnChicle_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chicle");
        }
        private async void BtnCaramelo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Caramelo");
        }
        private async void BtnDulces_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Dulces");
        }
        private async void BtnDulceDeMembrillo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Dulce de Membrillo");
        }
        private async void BtnFlan_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Flan");
        }
        private async void BtnGalletitas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Galletitas");
        }
        private async void BtnHelados_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Helados");
        }
        private async void BtnTorta_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Torta");
        }
        #endregion

        #region Carnes 
        private async void BtnAsado_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Asado");
        }
        private async void BtnAtun_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Atún");
        }
        private async void BtnChivito_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chivito");
        }
        private async void BtnChorizo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chorizo");
        }
        private async void BtnCarne_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Carne");
        }
        private async void BtnCarnePollo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Carne de Pollo");
        }
        private async void BtnCarnePescado_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Carne de Pescado");
        }
        private async void BtnEmpanada_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Empanada");
        }

        private async void BtnHamburguesa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hamburguesa");
        }
        private async void BtnJamon_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("jamón");
        }
        private async void BtnMilanesaAlPan_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Milanesa al Pan");
        }
        private async void BtnRefuerzo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Refuerzo");
        }
        #endregion

        #region Frutas - Verduras
        private async void BtnVerduras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.ComidasCategory.VerdurasPage());
        }
        private async void BtnFrutas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.ComidasCategory.FrutasPage());
        }
        #endregion

        #region Lácteos - Cereales
        private async void BtnArroz_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Arroz");
        }
        private async void BtnChocolatada_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chocolatada");
        }
        private async void BtnCafe_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Café");
        }
        private async void BtnCrema_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Crema Doble");
        }
        private async void BtnDulceDeLeche_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Dulce de Leche");
        }
        private async void BtnLeche_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Leche");
        }
        private async void BtnMani_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Maní");
        }
        private async void BtnMate_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mate");
        }
        private async void BtnManteca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Manteca");
        }
        private async void BtnPan_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Pan");
        }
        private async void BtnQueso_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Queso");
        }
        private async void BtnTortaFrita_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Torta Frita");
        }
        private async void BtnYogur_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Yogur");
        }
        #endregion
    }
}
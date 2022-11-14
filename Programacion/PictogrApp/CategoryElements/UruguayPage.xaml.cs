using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UruguayPage : ContentPage
    {
        public UruguayPage()
        {
            InitializeComponent();
        }
        private async void BtnArtigas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.ArtigasPage());
        }
        private async void BtnCanelones_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.CanelonesPage());
        }
        private async void BtnCerroLargo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.CerroLargoPage());
        }
        private async void BtnColonia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.ColoniaPage());
        }
        private async void BtnDurazno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.DuraznoPage());
        }
        private async void BtnFlores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.FloresPage());
        }
        private async void BtnFlorida_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.FloridaPage());
        }
        private async void BtnLavalleja_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.LavallejaPage());
        }
        private async void BtnMaldonado_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.MaldonadoPage());
        }
        private async void BtnMontevideo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.MontevideoPage());
        }
        private async void BtnPaysandu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.PaysanduPage());
        }
        private async void BtnRioNegro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.RioNegroPage());
        }
        private async void BtnRivera_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.RiveraPage());
        }
        private async void BtnRocha_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.RochaPage());
        }
        private async void BtnSalto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.SaltoPage());
        }
        private async void BtnSanJose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.SanJosePage());
        }
        private async void BtnSoriano_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.SorianoPage());
        }
        private async void BtnTacuarembo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.TacuaremboPage());
        }
        private async void BtnTreintaYTres_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.UruguayCategory.TreintaYTresPage());
        }
    }
}
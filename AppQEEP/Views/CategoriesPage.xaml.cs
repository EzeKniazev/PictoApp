using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQEEP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }
        #region BtnCategorías
        private async void BtnAcciones_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.AccionesPage());
        }
        private async void BtnFamilia_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.FamiliaPage());
        }
        private async void BtnEmocionesS_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.EmocionesSPage());
        }
        private async void BtnTiempo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.TiempoPage());
        }
        private async void BtnJuguetes_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.JuguetesPage());
        }
        private async void BtnDeportes_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryElements.DeportesPage());
        }
        #endregion
    }
}

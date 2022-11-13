using PictogrApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace PictogrApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ABMCats : ContentPage
    {
        public ABMCats()
        {
            InitializeComponent();
            MostrarDatosCat();
        }

        private void LimpiarCat()
        {
            TxtCodCat.Text = "";
            TxTNomCat.Text = "";
        }

        public bool ValidarDatosCat()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(TxTNomCat.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        public async void MostrarDatosCat()
        {
            //mostrar la base de datos despues de registrar la categoria
            var CatList = await App.SQLiteDB.GetCatAsync();
            if (CatList != null)
            {
                LstCat.ItemsSource = CatList;
            }
        }

        private async void LstCat_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (MCategorias)e.SelectedItem;
            BtnRegistrarCat.IsVisible = false;
            TxTNomCat.IsVisible = true;
            BtnActualizarCat.IsVisible = true;
            BtnEliminarCat.IsVisible = true;
            if (!string.IsNullOrEmpty(obj.CodCat.ToString()))
            {
                var cat = await App.SQLiteDB.GetCatByCodAsync(obj.CodCat);
                if (cat != null)
                {
                    TxtCodCat.Text = cat.CodCat.ToString();
                    TxTNomCat.Text = cat.NomCat;
                }
            }
        }

        private async void BtnRegistrarCat_Clicked(object sender, EventArgs e)
        {
            if (ValidarDatosCat())
            {
                MCategorias cat = new MCategorias
                {
                    NomCat = TxTNomCat.Text
                };
                await App.SQLiteDB.SaveCatAsync(cat);
                await DisplayAlert("Registro", "Se guardo de manera exitosa la categoria", "Ok");
                LimpiarCat();
                MostrarDatosCat();
            }
            else
            {
                await DisplayAlert("Error", "Ingrese los datos", "Ok");
            }
        }

        private async void BtnActualizarCat_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCodCat.Text))
            {
                MCategorias categorias = new MCategorias()
                {
                    CodCat = Convert.ToInt32(TxtCodCat.Text),
                    NomCat = TxTNomCat.Text
                };
                await App.SQLiteDB.SaveCatAsync(categorias);
                await DisplayAlert("Modificación", "Se edito de manera exitosa la categoria", "Ok");
                TxtCodCat.IsVisible = false;
                BtnActualizarCat.IsVisible = false;
                BtnRegistrarCat.IsVisible = true;
                LimpiarCat();
                MostrarDatosCat();
            }
        }

        private async void BtnEliminarCat_Clicked(object sender, EventArgs e)
        {
            var cate = await App.SQLiteDB.GetCatByCodAsync(Convert.ToInt32(TxtCodCat.Text));
            if (cate != null)
            {
                if (CanDelete(cate))
                {
                    await App.SQLiteDB.DeleteCatAsync(cate);
                    await DisplayAlert("Eliminado", "La categoria a sido eliminada", "Ok");
                    TxtCodCat.IsVisible = false;
                    BtnActualizarCat.IsVisible = false;
                    BtnEliminarCat.IsVisible = false;
                    BtnRegistrarCat.IsVisible = true;
                    LimpiarCat();
                    MostrarDatosCat();
                }

            }
        }
        private bool CanDelete(MCategorias cate)
        {
            //tendria que hacer una select en pictograma para ver si 
            //existe alguno con esa categoria y en ese caso no se puede eliminar
            //to do: cargar pictograma; fijarse que ande el text to speech de la manera que precisamos
            //en caso de que no, buscar como cargar audio desde el microfono
            //hacer grids segun la cantidad de categorias
            return true;
        }
    }
}


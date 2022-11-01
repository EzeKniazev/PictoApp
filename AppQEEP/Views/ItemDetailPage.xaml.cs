using AppQEEP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppQEEP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
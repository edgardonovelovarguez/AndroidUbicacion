using System.ComponentModel;
using Xamarin.Forms;
using AndroidUbicacion.ViewModels;

namespace AndroidUbicacion.Views
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
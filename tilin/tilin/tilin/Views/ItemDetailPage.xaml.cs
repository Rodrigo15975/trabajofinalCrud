using System.ComponentModel;
using tilin.ViewModels;
using Xamarin.Forms;

namespace tilin.Views
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
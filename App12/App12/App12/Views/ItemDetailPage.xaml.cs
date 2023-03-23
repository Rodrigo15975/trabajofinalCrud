using App12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App12.Views
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
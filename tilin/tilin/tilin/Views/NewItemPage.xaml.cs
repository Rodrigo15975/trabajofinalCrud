using System;
using System.Collections.Generic;
using System.ComponentModel;
using tilin.Models;
using tilin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tilin.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
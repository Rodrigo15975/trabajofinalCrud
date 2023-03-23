using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuinto.VistaModelo
{
    partial class Prueba : ObservableObject
    {
        [ObservableProperty]
        string text;

        [ObservableProperty]
        int count;

        [RelayCommand]
        public void Actualizartexto()
        {
            Count++;
            Text = $"Hola {Count}";
        }
    }
}
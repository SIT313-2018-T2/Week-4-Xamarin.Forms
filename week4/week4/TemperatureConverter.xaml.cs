using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace week4
{
    public partial class TemperatureConverter : ContentPage
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e){
   txtFah.Text = (int.Parse(txtCelsius.Text) * 1.8 + 32.0).ToString();

} 

    }
}

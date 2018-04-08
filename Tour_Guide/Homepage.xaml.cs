using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tour_Guide
{
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            InitializeComponent();
        }

        void Trail_Button(object sender, System.EventArgs e)
        {
            DisplayAlert ("Demo", "Only the river side walk is availible during this demo", "OK");
            Navigation.PushAsync(new Trails());
        }
    }
}
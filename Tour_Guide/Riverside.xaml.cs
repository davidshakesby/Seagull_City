using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tour_Guide
{
    public partial class Riverside : ContentPage
    {
        public Riverside()
        {
            InitializeComponent();
        }

        void Coast_Start(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Start_Riverside());
        }

    }
}

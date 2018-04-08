using System;

using Xamarin.Forms;

namespace Tour_Guide
{
    public class TrailView : ContentPage
    {
        public TrailView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


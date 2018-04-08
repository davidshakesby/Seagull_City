using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tour_Guide
{
    public partial class Trails : ContentPage
    {
        public Trails()
        {
            InitializeComponent();
            /*TrailView.ItemsSource = new List<string> {
                "Mowbray Park and Winter Gardens",
                "Fawcett Street",
                "Burdon Road And Ashbrooke",
                "High Street East",
                "Old Sunderland and the East End",
                "High Street West to the Coast",
                "Wearmouth's Bridges",
                "Riverside Walk to the Coast",
                "Roker and Whitburn",
                "Hylton Castle",
                "Walks Around Sunderland",
                "Cycling Tours in and around Sundeland"
            };*/
        }
        /*void Mowbary_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Fawcett_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Burdon_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void East_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Old_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void West_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Bridges_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }*/
        void Coast_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Riverside());
        }
        /*void Roker_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Hylton_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Walks_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }
        void Cycle_Button(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Trails());
        }*/
    
    }
}

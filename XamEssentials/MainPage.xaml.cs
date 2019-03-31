﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamEssentials.Views;

namespace XamEssentials
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DetectShakePage());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BarometerPage());
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GeocodingPage());
        }

        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GyroscopePage());
        }

        void Handle_Clicked_4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MagnetometerPage());
        }
    }
}

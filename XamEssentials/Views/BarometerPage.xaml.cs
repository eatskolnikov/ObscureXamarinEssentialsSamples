using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamEssentials.Views
{
    public partial class BarometerPage : ContentPage
    {
        public BarometerPage()
        {
            InitializeComponent();
            try
            {
                if (!Barometer.IsMonitoring)
                {
                    Barometer.ReadingChanged += ReadingChanged;
                    Barometer.Start(SensorSpeed.UI);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                lblMeasure.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                lblMeasure.Text = ex.Message;
            }
        }
        void ReadingChanged(object sender, BarometerChangedEventArgs e)
        {
            var data = e.Reading;
            lblMeasure.Text = $"Pressure In Hectopascals: X: {data.PressureInHectopascals}";
        }
    }
}

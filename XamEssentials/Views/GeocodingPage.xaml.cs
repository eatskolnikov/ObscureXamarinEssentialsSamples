using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamEssentials.Views
{
    public partial class GeocodingPage : ContentPage
    {
        public GeocodingPage()
        {
            InitializeComponent();
        }

        async void GetLocationData(object sender, System.EventArgs e)
        {
            try
            {
                var address = "Parque de las luces Santo Domingo DO";
                var locations = await Geocoding.GetLocationsAsync(address);
                var location = locations?.FirstOrDefault();
                if (location != null)
                {
                    lblLocation.Text = ($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }

            }
            catch (FeatureNotSupportedException fnsEx)
            {
                lblLocation.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                lblLocation.Text = ex.Message;
            }
        }
        async void GetPlaceMarkData(object sender, System.EventArgs e)
        {
            try 
            {
                var lat = 18.4663305;
                var lon = -69.9213416;
                var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    var geocodeAddress =
                        $"AdminArea:       {placemark.AdminArea}\n" +
                        $"CountryCode:     {placemark.CountryCode}\n" +
                        $"CountryName:     {placemark.CountryName}\n" +
                        $"FeatureName:     {placemark.FeatureName}\n" +
                        $"Locality:        {placemark.Locality}\n" +
                        $"PostalCode:      {placemark.PostalCode}\n" +
                        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                        $"SubLocality:     {placemark.SubLocality}\n" +
                        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                        $"Thoroughfare:    {placemark.Thoroughfare}\n";
                    lblPlacemark.Text = (geocodeAddress);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                lblPlacemark.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                lblPlacemark.Text = ex.Message;
            }
        }
    }
}

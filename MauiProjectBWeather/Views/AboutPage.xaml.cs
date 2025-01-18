using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;



namespace MauiProjectBWeather.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            //CheckInternetAccess();
        }


        //private async void CheckInternetAccess()
        //{
        //    bool isInternetAvailable = await IsInternetAvailable();
        //    if (isInternetAvailable)
        //    {
        //        await DisplayAlert("Internet Check", "Internet access is working!", "OK");
        //    }
        //    else
        //    {
        //        await DisplayAlert("Internet Check", "No internet access. Check permissions or connectivity.", "OK");
        //    }
        //}

        //private async Task<bool> IsInternetAvailable()
        //{
        //    try
        //    {
        //        using HttpClient client = new HttpClient();
        //        client.Timeout = TimeSpan.FromSeconds(5);
        //        HttpResponseMessage response = await client.GetAsync("https://www.google.com");
        //        return response.IsSuccessStatusCode;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}


        
    }
}

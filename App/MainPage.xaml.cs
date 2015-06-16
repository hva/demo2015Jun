using Newtonsoft.Json;
using System;
using WebApplication.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Web.Http;

namespace App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            using(var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:49527/api/matches", UriKind.Absolute);
                var str = await client.GetStringAsync(uri);
                var data = JsonConvert.DeserializeObject<Match[]>(str);
                ListView.ItemsSource = data;
            }
        }
    }
}

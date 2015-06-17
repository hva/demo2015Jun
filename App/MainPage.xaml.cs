using Microsoft.AspNet.SignalR.Client;
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
            const string host = "http://localhost:49527";
            //using (var client = new HttpClient())
            //{
            //    var uri = new Uri(host + "/api/matches", UriKind.Absolute);
            //    var str = await client.GetStringAsync(uri);
            //    var data = JsonConvert.DeserializeObject<Match[]>(str);
            //    ListView.ItemsSource = data;
            //}

            var connection = new HubConnection(host);

            var proxy = connection.CreateHubProxy("MatchesHub");

            await connection.Start();

            await proxy.Invoke("Hello");
        }
    }
}

using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WebApplication.Models;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App
{
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Match> collection;
        private int[] ids;

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

            var matches = await proxy.Invoke<List<Match>>("GetMatches");
            collection = new ObservableCollection<Match>(matches);
            ListView.ItemsSource = collection;
            ids = matches.Select(x => x.Id).ToArray();

            proxy.On<Match>("OnMatchUpdated", OnMatchUpdated);
        }

        private async void OnMatchUpdated(Match match)
        {
            //Debug.WriteLine(JsonConvert.SerializeObject(match));

            var index = Array.IndexOf(ids, match.Id);
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                collection.RemoveAt(index);
                collection.Insert(index, match);
            });
        }
    }
}

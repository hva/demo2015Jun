using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Threading;
using WebApplication.Models;

namespace WebApplication
{
    public class MatchesHub : Hub<IClient>
    {
        private readonly MatchesList matches;
        private readonly Timer timer;
        private readonly TimeSpan interval = TimeSpan.FromSeconds(0.5);
        private object locker = new object();
        private volatile bool isRunning = false;
        private Random random;

        public MatchesHub()
        {
            matches = new MatchesList();
            timer = new Timer(OnTimer, null, interval, interval);
            random = new Random();
        }

        public List<Match> GetMatches()
        {
            return matches;
        }

        private void OnTimer(object state)
        {
            lock (locker)
            {
                if (!isRunning)
                {
                    isRunning = true;

                    var index = random.Next(matches.Count);
                    var match = matches[index];

                    if (random.NextDouble() < 0.5)
                    {
                        match.ScoreHome++;
                    }
                    else
                    {
                        match.ScoreAway++;
                    }

                    Clients.All.OnMatchUpdated(match);

                    isRunning = false;
                }
            }
        }
    }

    public interface IClient
    {
        void OnMatchUpdated(Match match);
    }
}
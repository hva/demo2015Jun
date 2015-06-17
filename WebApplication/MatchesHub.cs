using Microsoft.AspNet.SignalR;

namespace WebApplication
{
    public class MatchesHub : Hub
    {
        public MatchesHub()
        {

        }

        public void Hello()
        {
            Clients.All.hello();
        }
    }
}
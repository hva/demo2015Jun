using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MatchesController : ApiController
    {
        public List<Match> Get()
        {
            return new MatchesList();
        }
    }
}

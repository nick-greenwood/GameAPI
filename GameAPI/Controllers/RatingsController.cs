using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GameAPI.Repositories;

namespace GameAPI.Controllers
{
    [AllowAnonymous]

    public class RatingsController : ApiController
    {
            private readonly RatingsRepo _RatingsRepo;
            private readonly GamesRepo _GamesRepo;

            public RatingsController()
            {
                _RatingsRepo = new RatingsRepo();
                _GamesRepo = new GamesRepo();
            }

            [HttpGet]
            public HttpResponseMessage AVGRatings()
            {
                var gamequery = _GamesRepo.GetAllGames();

                var query = _RatingsRepo
                    .GetAllRatings()
                    .GroupBy(r => r.GameId)
                    .Select(gr => new
                    {
                        gamename = gamequery.First(g => g.Id.Equals(gr.Key)).Name,
                        gameid = gr.Key,
                        avgrating = gr.ToList().Average(gra => gra.Number)
                    })
                    .OrderByDescending(avg => avg.avgrating);


                return Request.CreateResponse(HttpStatusCode.OK, query);
            }
        
    }
}

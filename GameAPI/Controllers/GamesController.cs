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

    public class GamesController : ApiController
    {
            //Games
            private readonly GamesRepo _GamesRepo;

            public GamesController()
            {
                _GamesRepo = new GamesRepo();
            }

            public HttpResponseMessage GetAll()
            {
                return Request.CreateResponse(HttpStatusCode.OK, _GamesRepo.GetAllGames());
            }

            public HttpResponseMessage GetByName(string name)
            {
                var query =
                    _GamesRepo.GetAllGames()
                        .Where(g => g.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                        .FirstOrDefault();

                return Request.CreateResponse(HttpStatusCode.OK, query);
            }

            public HttpResponseMessage GetByPartialName(string names)
            {

                var query = _GamesRepo.GetAllGames().Where(g => g.Name.Contains(names)).ToList();


                return Request.CreateResponse(HttpStatusCode.OK, query);

                //http://localhost:24043/game/GetByPartialName?names=H
            }

     }
}


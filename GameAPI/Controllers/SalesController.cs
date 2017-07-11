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

    public class SalesController : ApiController
    {
        private readonly SalesRepo _salesRepository;

        public SalesController()
        {
            _salesRepository = new SalesRepo();
        }

        [HttpGet]
        [Route("SalesController/{gameId}/games")]
        public HttpResponseMessage MostSales()
        {
            var games = _salesRepository
                .GetAllSales()
                .GroupBy(s => s.GameId)
                .Select(m => new
                {
                    GameId = m.Key,
                    NumberOfSales = m.Count()
                })
                .OrderByDescending(m => m.NumberOfSales);

            return Request.CreateResponse(HttpStatusCode.OK, games);
        }

        [HttpGet]
        [Route("customers/{customerId}/orders")]
        public HttpResponseMessage MostMoneyMade()
        {
            var games = _salesRepository
                .GetAllSales()
                .GroupBy(s => s.GameId)
                .Select(m => new
                {
                    GameId = m.Key,
                    MoneyMade = m.Sum(mm => mm.Price)
                })

                .OrderByDescending(m => m.MoneyMade);


            return Request.CreateResponse(HttpStatusCode.OK, games);
        }
    }
}

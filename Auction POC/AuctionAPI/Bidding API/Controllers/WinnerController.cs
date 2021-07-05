using Services;
using Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using DomainLayer.Entities;

namespace Auction_API.Controllers
{
    [Route("api/winner")]
    [ApiController]
    public class WinnerController : ControllerBase
    {
        private readonly IWinnerService _winnerService;

        public WinnerController()
        {
            _winnerService = new WinnerService();
        }

        [HttpPost]
        public Winner Post(Winner winner)
        {
            try
            {
                _winnerService.Add(winner);

                return winner;
            }
            catch (Exception exc)
            {
                return new Winner();
            }
        }
    }
}

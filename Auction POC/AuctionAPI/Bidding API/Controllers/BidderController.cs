using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;
using System;
using System.Collections.Generic;


namespace Auction_API.Controllers
{
    [Route("api/bidder")]
    [ApiController]
    public class BidderController : ControllerBase
    {
        private readonly IBidderService _bidderService;

        public BidderController()
        {
            _bidderService = new BidderService();
        }

        [HttpPost]
        public List<Bidder> Post(List<Bidder> biddersList)
        {
            try
            {
                _bidderService.Add(biddersList);

                return biddersList;
            }
            catch (Exception exc)
            {
                return new List<Bidder>();
            }
        }
    }
}

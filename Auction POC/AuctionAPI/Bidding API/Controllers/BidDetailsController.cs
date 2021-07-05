using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;
using System;
using System.Net;
using System.Net.Http;
using DomainLayer.ViewModels;
using Newtonsoft.Json;
using System.Text;
using DomainLayer.Entities;
using System.Collections.Generic;

namespace Auction_API.Controllers
{
    [Route("api/biddetails")]
    [ApiController]
    public class BidDetailsController : ControllerBase
    {
        private readonly IBidDetailsService _bidDetailsService;

        public BidDetailsController()
        {
            _bidDetailsService = new BidDetailsService();
        }

        [HttpPost]
        public List<BidDetails> Post(List<BidDetails> bidDetails)
        {
            try
            {
                _bidDetailsService.Add(bidDetails);


                return bidDetails;
            }
            catch (Exception exc)
            {
                return new List<BidDetails>();
            }
        }
    }
}

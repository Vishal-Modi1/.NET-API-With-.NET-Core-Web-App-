using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;
using System;

namespace Auction_API.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemDetailsController : ControllerBase
    {
        private readonly IItemDetailsService _itemDetailsService;

        public ItemDetailsController()
        {
            _itemDetailsService = new ItemDetailsService();
        }

        [HttpPost]
        public ItemDetails Post(ItemDetails itemDetails)
        {
            try
            {
               return _itemDetailsService.Add(itemDetails);
                
            }
            catch(Exception exc)
            {
                return new ItemDetails();
            }
        }
    }
}

using DomainLayer.Entities;
using DomainLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Presentation_Layer.Controllers
{
    public class BidDetailsController : Controller
    {
        private HttpClient _httpClient;
        private readonly string _apiPrefix = "https://localhost:44329/";

        public IActionResult Index()
        {
            return PartialView();
        }

        public IActionResult SaveAuctionDetails(BidAutionDetailsVM bidAutionDetailsVM)
        {
            bidAutionDetailsVM.ItemDetails = SaveItemDetails(bidAutionDetailsVM.ItemDetails);

            if(bidAutionDetailsVM.ItemDetails.Id == 0)
            {
                // return error;
            }

            bidAutionDetailsVM.Bidders =  SaveBidders(bidAutionDetailsVM);

            bidAutionDetailsVM.BidDetailsList =  SaveBidDetails(bidAutionDetailsVM);

            SaveWinner(bidAutionDetailsVM);

            return PartialView("Index");
        }

        private ItemDetails SaveItemDetails(ItemDetails itemDetails)
        {
            _httpClient = new HttpClient();

            string json = JsonConvert.SerializeObject(itemDetails);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _httpClient.PostAsync($"{ _apiPrefix }api/items", content).Result;

            string data = response.Content.ReadAsStringAsync().Result;
            itemDetails = JsonConvert.DeserializeObject<ItemDetails>(data);

            return itemDetails;
        }

        private List<Bidder> SaveBidders(BidAutionDetailsVM bidAutionDetailsVM)
        {
            _httpClient = new HttpClient();

            string json = JsonConvert.SerializeObject(bidAutionDetailsVM.Bidders);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _httpClient.PostAsync($"{ _apiPrefix }api/bidder", content).Result;

            string data = response.Content.ReadAsStringAsync().Result;
            bidAutionDetailsVM.Bidders = JsonConvert.DeserializeObject<List<Bidder>>(data);

            return bidAutionDetailsVM.Bidders;
        }

        private List<BidDetails> SaveBidDetails(BidAutionDetailsVM bidAutionDetailsVM)
        {
            _httpClient = new HttpClient();

            List<BidDetails> bidDetailsList = new List<BidDetails>();

            foreach (BidDetailsVM bidDetailsVM in bidAutionDetailsVM.BidDetails)
            {
                BidDetails bidDetails = new BidDetails();
                bidDetails.BidAmount = bidDetailsVM.Price;
                bidDetails.Profit =   bidDetailsVM.Price - bidAutionDetailsVM.ItemDetails.Price;
                bidDetails.BidderId = bidAutionDetailsVM.Bidders.Where(p=>p.Name == bidDetailsVM.BidderName).First().Id;
                bidDetails.ItemId = bidAutionDetailsVM.ItemDetails.Id;

                bidDetailsList.Add(bidDetails);
            }

            bidAutionDetailsVM.BidDetailsList = bidDetailsList;

            string json = JsonConvert.SerializeObject(bidAutionDetailsVM.BidDetailsList);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _httpClient.PostAsync($"{ _apiPrefix }api/biddetails", content).Result;
            
            string data = response.Content.ReadAsStringAsync().Result;
            bidAutionDetailsVM.BidDetailsList = JsonConvert.DeserializeObject<List<BidDetails>>(data);

            return bidAutionDetailsVM.BidDetailsList;
        }

        private void SaveWinner(BidAutionDetailsVM bidAutionDetailsVM)
        {
            Winner winner = new Winner();
            winner.BidDetailsId = bidAutionDetailsVM.BidDetailsList.OrderByDescending(p => p.BidAmount).First().Id;

            string json = JsonConvert.SerializeObject(winner);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _httpClient.PostAsync($"{ _apiPrefix }api/winner", content).Result;
        }
    }
}

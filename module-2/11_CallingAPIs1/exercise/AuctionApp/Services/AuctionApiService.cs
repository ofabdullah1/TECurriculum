﻿using RestSharp;
using System.Collections.Generic;
using AuctionApp.Models;

namespace AuctionApp.Services
{
    public class AuctionApiService
    {
        public IRestClient client;

        public AuctionApiService(string apiUrl)
        {
            client = new RestClient(apiUrl);
        }

        public List<Auction> GetAllAuctions()
        {
            // Do a Get request to localhost:3000/auctions
            RestRequest request = new RestRequest("auctions");

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);


            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            // Do a Get requests to localhost:3000/reviews?hotelId={hotelId}
            RestRequest request = new RestRequest("auctions/" + auctionId);

            IRestResponse<Auction> response = client.Get<Auction>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTerm)
        {
            RestRequest request = new RestRequest("auctions?title_like=" + searchTerm);

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest("auctions?currentBid_lte=" + searchPrice);

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }
    }
}

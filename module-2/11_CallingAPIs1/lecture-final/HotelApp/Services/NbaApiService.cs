using HotelApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelApp.Services
{
    public class NbaApiService
    {

      
        private RestClient client;
       

        public NbaApiService(string apiUrl)
        {
            if (client == null)
            {
                // This URL is the "base url". All requests wil be based on this URL with a URL appended.
                client = new RestClient(apiUrl); // localhost:3000
            }
        }

        public Player GetPlayer(int playerId)
        {
            // Do a GET request to localhost:3000/hotels/{hotelId}
            RestRequest request = new RestRequest("players/" + playerId);

            IRestResponse<Player> response = client.Get<Player>(request);

            return response.Data;
        }


    }
}

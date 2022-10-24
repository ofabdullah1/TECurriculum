using HotelApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelApp.Services
{
    public class HotelApiService
    {
        private RestClient client;

        public HotelApiService(string apiUrl)
        {
            if (client == null)
            {
                // This URL is the "base url". All requests will be based on this URL with URL appended.
                client = new RestClient(apiUrl); //localhost:3000
            }
        }

        public List<Hotel> GetHotels()
        {
            // Do a Get request to localhost:3000/hotels
            RestRequest request = new RestRequest("hotels");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>> (request);


            return response.Data;
        }

        public List<Review> GetReviews()
        {
            // Do a Get request to localhost:3000/reviews
            RestRequest request = new RestRequest("reviews");

            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);


            return response.Data;
        }

        public Hotel GetHotel(int hotelId)
        {
           
            // Do a GET request to localhost:3000hotels/{hotelId}
            RestRequest request = new RestRequest("hotels/" + hotelId);

            IRestResponse<Hotel> response = client.Get<Hotel>(request);

            return response.Data;
        }

        public List<Review> GetHotelReviews(int hotelId)
        {
            // Do a Get requests to localhost:3000/reviews?hotelId={hotelId}
            RestRequest request = new RestRequest($"reviews?hotelId={hotelId}");

            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);

            return response.Data;

        }

        public List<Hotel> GetHotelsWithRating(int starRating)
        {
            // Do a Get requests to localhost:3000/reviews?hotelId={starRating}
            RestRequest request = new RestRequest("hotels?stars=" + starRating);

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            return response.Data;
        }

        public City GetPublicAPIQuery()
        {
            throw new NotImplementedException();
        }
    }
}

using HotelApp.Models;
using HotelApp.Services;
using RestSharp;
using System;
using System.Collections.Generic;

namespace HotelApp
{
    public class HotelApp
    {
        private HotelApiService hotelApiService;
        private HotelConsoleService console = new HotelConsoleService();

        public HotelApp(string apiURL)
        {
            this.hotelApiService = new HotelApiService(apiURL);
        }

        public void Run()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                console.PrintMainMenu();
                int menuSelection = console.PromptForInteger("Please choose an option", 0, 6);

                switch (menuSelection)
                {
                    case 0: // Exit the loop

                        keepGoing = false;
                        break;

                    case 1: // List hotels
                        ShowHotels();
                        break;

                    case 2: // List Reviews
                        ShowReviews();
                        break;

                    case 3: // Show details for hotel 1
                        ShowHotelDetails(1);
                        break;

                    case 4: // List reviews for hotel 1
                        ShowHotelReviews(1);
                        break;

                    case 5: // List hotels with star rating of 3
                        FilterHotelsByRating(3);
                        break;

                    case 6: // Public API Query
                        CallStarWarsAPI();
                        break;

                    case 7: // Public API Query
                        CallNbaAPI();
                        break;
                }
            }
        }

        private void ShowHotels()
        {
            List<Hotel> hotels = hotelApiService.GetHotels();
            if (hotels != null)
            {
                console.PrintHotels(hotels);
            }
            console.Pause();
        }

        private void ShowReviews()
        {
            List<Review> reviews = hotelApiService.GetReviews();
            if (reviews != null)
            {
                console.PrintReviews(reviews);
            }
            console.Pause();
        }

        private void ShowHotelDetails(int hotelId)
        {
            Hotel hotel = hotelApiService.GetHotel(hotelId);
            if (hotel != null)
            {
                console.PrintHotel(hotel);
            }
            console.Pause();
        }

        private void ShowHotelReviews(int hotelId)
        {
            List<Review> reviews = hotelApiService.GetHotelReviews(hotelId);
            if (reviews != null)
            {
                console.PrintReviews(reviews);
            }
            console.Pause();
        }

        private void FilterHotelsByRating(int rating)
        {
            List<Hotel> hotels = hotelApiService.GetHotelsWithRating(rating);
            if (hotels != null)
            {
                console.PrintHotels(hotels);
            }
            console.Pause();
        }

        private void CallStarWarsAPI()
        {
            // GET to https://swapi.dev/api/starships/9
            RestRequest request = new RestRequest("https://swapi.dev/api/starships/9");

            RestClient client = new RestClient();
            IRestResponse<Starship> response = client.Get<Starship>(request);

            Starship deathStar = response.Data;

            Console.WriteLine(deathStar.Name);
            Console.WriteLine(deathStar.Model);
            Console.WriteLine(deathStar.Manufacturer);

            console.Pause();
        }

        private void CallNbaAPI()
        {
            // GET to https://www.balldontlie.io/api/v1/players/237
            RestRequest request = new RestRequest("https://www.balldontlie.io/api/v1/players/237");

            RestClient client = new RestClient();
            IRestResponse<Player> response = client.Get<Player>(request);

            Player lebronJames = response.Data;

            Console.WriteLine(lebronJames.firstName);
            Console.WriteLine(lebronJames.lastName);
            Console.WriteLine(lebronJames.Team);
          
            

            console.Pause();
        }
    }
}

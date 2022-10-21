using HotelApp.Models;
using HotelApp.Services;
using System;
using System.Collections.Generic;

namespace HotelApp
{
    public class HotelApp
    {
        private readonly HotelApiService hotelApiService;
        private readonly HotelConsoleService console = new HotelConsoleService();

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
                        PrintCity();
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

        private void PrintCity()
        {
            City city = hotelApiService.GetPublicAPIQuery();
            if (city != null)
            {
                console.PrintCity(city);
            }
            console.Pause();
        }
    }
}

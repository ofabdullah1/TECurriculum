using PetInfo.APIServices;
using PetInfoClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;


namespace PetInfoClient.APIServices
{
    public class UserAPIService : LoginAPIService
    {
        private readonly string API_URL = "https://localhost:44349/user/";

        public List<User> GetUsers()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<User>> response = client.Get<List<User>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }
        }
    }
}

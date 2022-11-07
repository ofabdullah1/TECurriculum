

using PetInfoServer.Models;
using System.Collections.Generic;

namespace PetInfoServer.DAL
{
    public interface IUserDAO
    {
        User GetUser(string username);
        List<User> GetUsers();
        User AddUser(string username, string password);
    }
}

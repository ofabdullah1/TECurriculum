using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfoClient.Models
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }


        public override string ToString()
        {
            return $"{ID} - {UserName}";
        }
    }
}

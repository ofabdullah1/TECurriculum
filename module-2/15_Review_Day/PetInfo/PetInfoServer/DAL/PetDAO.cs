using PetInfoClient.Models;
using PetInfoServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PetInfoServer.DAL
{
    public class PetDAO :IPetDAO
    {
        private string connectionString;

        private string sqlGetPets = "SELECT * FROM pets;";

        public PetDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Pet> GetPets()
        {
            List<Pet> pets = new List<Pet>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlGetPets, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Pet pet = ReaderToPet(reader);
                        pets.Add(pet);

                    }

                }
            }
            catch (Exception ex)
            {
                pets = new List<Pet>();
            }

            return pets;
        }

        private Pet ReaderToPet(SqlDataReader reader)
        {
            Pet pet = new Pet();
            pet.Id = Convert.ToInt32(reader["id"]);
            pet.Name = Convert.ToString(reader["name"]);
            pet.Type = Convert.ToString(reader["type"]);
            pet.Breed = Convert.ToString(reader["breed"]);
            return pet;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public class ParkSqlDao : IParkDao
    {
        private readonly string connectionString;

        public ParkSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Park GetPark(int parkId)
        {
            //todo not done
            throw new NotImplementedException();
        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {
            //todo not done
            throw new NotImplementedException();
        }

        public Park CreatePark(Park park)
        {
            Park newPark = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO[dbo].[park] ([park_name] ,[date_established],[area],[has_camping]) " +
                    " VALUES (@park_name, @date_established, @area, @has_camping); SELECT @@IDENTITY";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@park_name", park.ParkName);
                cmd.Parameters.AddWithValue("@date_established", park.DateEstablished);
                cmd.Parameters.AddWithValue("@area", park.Area);
                cmd.Parameters.AddWithValue("@has_camping", park.HasCamping);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                park.ParkId = result;
  

            }

            
            
            return park;
        }

        public void UpdatePark(Park park)
        {
            //todo not done
            throw new NotImplementedException();
        }

        public void DeletePark(int parkId)
        {
            //todo not done
            throw new NotImplementedException();
        }

        public void AddParkToState(int parkId, string state_abbreviation)
        {
            //todo not done
            throw new NotImplementedException();
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            //todo not done
            throw new NotImplementedException();
        }

        private Park CreateParkFromReader(SqlDataReader reader)
        {
            //todo not done
            throw new NotImplementedException();
        }
    }
}

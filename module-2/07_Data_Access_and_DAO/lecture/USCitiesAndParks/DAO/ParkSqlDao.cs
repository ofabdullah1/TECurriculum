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
            //todo not done
            throw new NotImplementedException();
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

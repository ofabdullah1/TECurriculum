using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DadabaseApp
{
    public class JokesDAO
    {
        private string connString;

        public JokesDAO(string connString)
        {
            this.connString = connString;
        }

        public int UpdateAllJokes(int humorLevel)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                const string sql = "UPDATE Joke SET humor_level_id = @humor_level";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@humor_level", humorLevel);

                int rows = command.ExecuteNonQuery();

                return rows;
            }
        }

        public int InsertJoke(Joke newJoke)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string sql = "INSERT INTO Joke (setup, punchline, humor_level_id) VALUES (@setup, @punchline, @level_id); SELECT @@IDENTITY;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@setup", newJoke.Setup);
                command.Parameters.AddWithValue("@punchline", newJoke.Punchline);
                command.Parameters.AddWithValue("@level_id", newJoke.HumorLevelId);

                int id = Convert.ToInt32(command.ExecuteScalar());
                newJoke.Id = id;

                return id;
            }
        }

        public List<Joke> GetAllJokes()
        {
            List<Joke> results = new List<Joke>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT j.joke_id AS id, j.setup, j.punchline, h.name AS humor_level FROM Joke j " +
                    "INNER JOIN HumorLevel h ON h.level_id = j.humor_level_id ORDER BY h.level_id DESC, j.setup ASC, j.punchline ASC";

                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Joke joke = new Joke();

                    joke.Setup = Convert.ToString(reader["setup"]);
                    joke.Punchline = Convert.ToString(reader["punchline"]);
                    joke.HumorLevel = Convert.ToString(reader["humor_level"]);
                    joke.Id = Convert.ToInt32(reader["id"]);

                    results.Add(joke);
                }

            }

            return results;
        }
    }
}

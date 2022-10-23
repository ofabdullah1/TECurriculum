using System;
using System.Collections.Generic;
using System.Text;

namespace DadabaseApp
{
    public class Joke
    {
        public string Setup { get; set; }

        public string Punchline { get; set; }

        public int Id { get; set; }

        public string HumorLevel { get; set; }

        public int HumorLevelId { get; set; }

        public override string ToString()
        {
            return Setup + Environment.NewLine + Punchline + " (" + HumorLevel + ")";
        }
    }
}

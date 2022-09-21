﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "Herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> groups = new Dictionary<string, string>();

            groups["rhino"] = "Crash";
            groups["giraffe"] = "Tower";
            groups["elephant"] = "Herd";
            groups["lion"] = "Pride";
            groups["crow"] = "Murder";
            groups["pigeon"] = "Kit";
            groups["flamingo"] = "Pat";
            groups["deer"] = "Herd";
            groups["dog"] = "Pack";
            groups["crocodile"] = "Float";

            if (animalName == null)

            {
                return "unknown";
            }
            animalName = animalName.ToLower();

            if (groups.ContainsKey(animalName) == true)

            {
                return groups[animalName];
            }
            else return "unknown";








        }
    }
}

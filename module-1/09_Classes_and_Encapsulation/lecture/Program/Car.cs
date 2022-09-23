using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Car
    {
        private string vinNumber = "";
        private int year = 0;

        public string VinNumber
        {
            get
            {
                return vinNumber;
            }
            set
            {
                vinNumber = value;
            }

        }

        public int Year
        {
            get
            {
                return year;
            }
            private set
            {
                year = value;
            }
        }

        public string Manf
        {
            get; set;
        } = "Honda";

        public string Model
        {
            get; private set;
        }


        public Car()
        {
            VinNumber = "0000000000000000";
            Year = 2023;
            Manf = "Toyota";
            Model = "Tercel";
        }


        public Car(string vinNumber, int year, string manf, string model)
        {
            VinNumber = vinNumber;
            Year = year;
            Manf = manf;
            Model = model;
        }


        public override string ToString()
        {
            return vinNumber + " - " + year + " - " + Manf;
        }
    }
}

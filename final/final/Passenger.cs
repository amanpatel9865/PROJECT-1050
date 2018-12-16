using System;

namespace final

{

    public class Passenger

    {

        private string Name;

        private double Weight;

        public static double SumOfWeight = 0;



        public Passenger(string name, double weight)

        {

            Name = name;

            Weight = weight;
            SumOfWeight += weight;



        }


        public string GetName()

        {

            return Name;


        }

        public double GetWeight()

        {

            return Weight;

        }


    }

}
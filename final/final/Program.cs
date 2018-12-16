﻿namespace final

{ 

    class Program

    {

        static void Main(string[] args)

        {

            Elevator elevator1 = new Elevator(2, 400);

            Passenger A1 = new Passenger("A1", 180);

            elevator1.AddOccupant(A1, 0);

            Passenger A2 = new Passenger("A2", 220);

            elevator1.AddOccupant(A2, 1);

            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            System.Console.WriteLine(elevator1IsOverMaxCapacity);

            /////////////////////////////////////////////////////////////////////     
            ///////////////////Now for Elevator 2////////////////////////////////
            ////////////////////////////////////////////////////////////////////

            Elevator elevator2 = new Elevator(3, 600);

            A1 = new Passenger("A1", 200);

            elevator2.AddOccupant(A1, 0);

            A2 = new Passenger("A2", 200);

            elevator2.AddOccupant(A2, 1);

            Passenger A3 = new Passenger("A3", 201);

            elevator2.AddOccupant(A3, 1);

            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

            System.Console.WriteLine(elevator2IsOverMaxCapacity);

            System.Console.ReadKey();

        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4_3
{
    namespace TrafficSimulationSystem
    {
        public interface IDriveable
        {
            void Move();
            void Stop();
        }

        public class Road
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public int NumberOfLanes { get; set; }
            public int TrafficLevel { get; set; }
        }

        public class Vehicle : IDriveable
        {
            public int Speed { get; set; }
            public double Size { get; set; }
            public string Type { get; set; }

            public void Move()
            {
                Console.WriteLine("Vehicle is moving.");
            }

            public void Stop()
            {
                Console.WriteLine("Vehicle has stopped.");
            }
        }

        public class TrafficSimulation
        {
            public static void Simulate(Vehicle vehicle, Road road)
            {
                if (vehicle.Speed < 30 && road.TrafficLevel > 5)
                {
                    vehicle.Stop();
                }
                else
                {
                    vehicle.Move();
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Road road = new Road
                {
                    Length = 1000.0,
                    Width = 10.0,
                    NumberOfLanes = 4,
                    TrafficLevel = 7
                };

                Vehicle car = new Vehicle
                {
                    Speed = 40,
                    Size = 5.0,
                    Type = "Car"
                };

                TrafficSimulation.Simulate(car, road);

                Console.ReadLine();
            }
        }
    }
}


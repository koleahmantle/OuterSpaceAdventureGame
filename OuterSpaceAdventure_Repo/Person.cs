using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuterSpaceAdventure_Repo
{
    public class Person
     { 
        public string Name { get; set; }
        public int Age { get; set; }
        public TransportationType Transportation { get; set; }
        //public LocationType PreviousLocation { get; set; }
        public LocationType CurrentLocation { get; set; }
        //public ulong DistanceTraveled { get; set; }

        public bool IsAlive
        {
            get
            {
                if (this.CurrentLocation is LocationType.Blackhole)
                {
                    Console.WriteLine("You are now exiting this universe, good luck in the next!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public Person(){}
      
        public Person(string name, int age, int randLocation, int randTransportation)
        {
            Name = name;
            Age = age;
            Transportation = (TransportationType)randTransportation;
            //PreviousLocation = LocationType.Earth;
            CurrentLocation = (LocationType)randLocation;
        }


        //private List<ulong> _distancesFromEarth = new List<ulong>()
        //{
        //    0L, //earth
        //    238900L, //moon
        //    390400000L, //Europa
        //    484000000L, //Jupiter
        //    0L         //blackhole
        //};
    }
}

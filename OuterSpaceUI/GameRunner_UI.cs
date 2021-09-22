using OuterSpaceAdventure_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuterSpaceUI
{
    public class GameRunner_UI
    {
        public void Run()
        {
            _player = StartGame();

            while (_player.IsAlive)            
            {
                DisplayResult();
                NextLocation();
                NextTravelType();
                Console.ReadLine();
            }
        }

        private Person _player = new Person();
        public Person StartGame()
        {
            Console.WriteLine("Welcome Space Traveler, lets set off on a journey.");

            Console.WriteLine("Please enter your Name.");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age.");
            int age = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int initalLocation = rand.Next(1, 6);
            int initialTravelType = rand.Next(1, 4);

            Person person = new Person(name, age, initalLocation, initialTravelType);

            return person;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"{_player.Name} you made it while avoiding black holes, congrats! I guess this is why they call it roulette. \n" +
                $"Welcome to {_player.CurrentLocation}. \n" +
                $"You traveled by {_player.Transportation}. \n");
        }

        public void NextLocation()
        {
            Console.WriteLine("Press any key to roll the dice and choose your new travel location and type.");
            Console.ReadKey();
            Random rand = new Random();
            int newLocation = rand.Next(1, 6);
          //  _player.PreviousLocation = _player.CurrentLocation;
            _player.CurrentLocation = (LocationType)newLocation;
        }

        public void NextTravelType()
        {
            Random rand = new Random();
            int newTravelType = rand.Next(1, 4);
            _player.Transportation = (TransportationType)newTravelType;
        }
       
     }
}

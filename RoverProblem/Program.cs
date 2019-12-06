using System;


namespace RoverProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverPosition _position = new RoverPosition();
            string _userInput;
            string _commands;
            Rover _rover;

            Console.WriteLine("Welcome to the Rover Problem!");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Please Specify the initial Position of the Rover");

            Console.WriteLine("X-Coordinate:");
            _userInput = Console.ReadLine();
            _position.SetXCord(Convert.ToInt32(_userInput));

            Console.WriteLine("Y-Coordinate:");
            _userInput = Console.ReadLine();
            _position.SetYCord(Convert.ToInt32(_userInput));

            Console.WriteLine("Facing Direction:");
            _userInput = Console.ReadLine();
            _position.SetDirection(_userInput[0]);

            Console.WriteLine("Please Specify the Command String for the Rover:");
            _commands = Console.ReadLine();


            Console.WriteLine("_____________________________");

            _rover = new Rover(_position);

            _rover.PrintPosition("Initial");
            _rover.ExecuteCommands(_commands);
            _rover.PrintPosition("Final");

            Console.WriteLine("_____________________________");
        }
    }
}

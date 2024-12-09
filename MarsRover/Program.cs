namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input plateau size");
            string platString = Console.ReadLine();

            Console.WriteLine("Please input Rover Position");
            string RoverString = Console.ReadLine();

            Console.WriteLine("Enter Instructions");
            string InstructionString = Console.ReadLine();

            Console.WriteLine("Creating 5 by 5 grid");

            string[,] sizes = new string[5,5];



            PlateauSize plateau = PlateauSize.GetInstance(sizes);
           
            string check = "2 2 N";
            InputParser inputParser = new InputParser();
            var RoverPos = inputParser.InputPosition(check);
            Rover1 rover1 = new Rover1(RoverPos);
            plateau.PopulatePlateau();



         //   Position pos = new Position(2, 1, CompassDirection.N);
            plateau.UpdatePlateau(rover1.position);
            plateau.DisplayPlateau();


            List<Instruction> testIns = new List<Instruction>();
         //   testIns.Add(Instruction.R);
            testIns.Add(Instruction.M);
            rover1.MoveRover(testIns);

            plateau.UpdatePlateau(rover1.position);
            plateau.DisplayPlateau();

            //Console.WriteLine(inputParser.InputPosition(check).x);
            //Console.WriteLine(inputParser.InputPosition(check).y);
            //Console.WriteLine(inputParser.InputPosition(check).facing);
        }
    }
}

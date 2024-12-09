using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InputParser
    {
        public InputParser() { }


        public int[,] InputPlatau(string input)
        {
            int[] sizes = new int[2];
            sizes[0] = Int32.Parse(input.Split(" ")[0]);
            sizes[1] =Int32.Parse(input.Split(" ")[1]);
            int[,] platauSize = new int[sizes[0], sizes[1]];


            return platauSize;
        }

        public bool TestUserInput(string input)
        {
            return false;
        }
        public Position InputPosition(string input)
        {
            int[] sizes = new int[2];
            CompassDirection inDirection = CompassDirection.S;
            sizes[0] = Int32.Parse(input.Split(" ")[0]);
            sizes[1] = Int32.Parse(input.Split(" ")[1]);
            if (input.Split(" ")[2] == "N") inDirection = CompassDirection.N;
            if (input.Split(" ")[2] == "S") inDirection = CompassDirection.S;
            if (input.Split(" ")[2] == "E") inDirection = CompassDirection.E;
            if (input.Split(" ")[2] == "W") inDirection = CompassDirection.W;

            Position RoverStart = new Position(sizes[0], sizes[1], inDirection);          

            return RoverStart;

        }

        public List<Instruction> InputInstruction(string input)
        {
            List<Instruction> instructions = new List<Instruction>();
            foreach(char c in input)
            {
                if (c == 'L') instructions.Add(Instruction.L);
                if (c == 'M') instructions.Add(Instruction.M);
                if (c == 'R') instructions.Add(Instruction.R);

            }



            return instructions;

        }
    }
}

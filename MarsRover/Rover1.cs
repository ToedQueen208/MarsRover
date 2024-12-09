using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover1
    {
        public Position position { get; set; }
        public Instruction instruction { get; set; }

       
        public Rover1(Position pos)
        {
            //When creating a Rover set it position
            position = pos;
        }


        public void MoveRover(List<Instruction> instructions)
        {
            CompassDirection currentdir = position.facing;
            
            foreach (Instruction instruction in instructions) {

                if (instruction == Instruction.L)
                {
                    currentdir = currentdir - 1;
                }
                else if (instruction == Instruction.R)
                {
                    currentdir = currentdir + 1;
                }
                else if(instruction == Instruction.M)
                {
                    if (currentdir == CompassDirection.N)
                    {
                        if (checkCanMove(position, new Position(position.x - 1, position.y, position.facing)))
                        {
                            Console.WriteLine("moving rover upwards 1 space");
                            position.y += 1;/* +1 to X colum*/
                        }
                    }                 
                    if (currentdir == CompassDirection.E) 
                    {
                        if (checkCanMove(position, new Position(position.x , position.y+1, position.facing)))
                        {
                            position.y += 1;/* +1 to Y colum*/
                        }
                    }                 
                    if (currentdir == CompassDirection.S) 
                    {
                        if (checkCanMove(position, new Position(position.x +1 , position.y, position.facing)))
                        {
                            position.x += 1;
                        } /* -1 to X colum*/
                    }                 
                    if (currentdir == CompassDirection.W)
                    {
                        if (checkCanMove(position, new Position(position.x, position.y-1, position.facing)))
                        {
                            position.y -= 1;
                        } /* -1 to Y colum*/
                    }                 
                    

                }


            }
             
              }
        public bool checkCanMove(Position oldPos, Position newPos)
        {
            //Gets Plateau Size
            //Checks if new pos would put it outside of that grid

           string[,] plats = PlateauSize.PlatSize;

            if (newPos.x < 0 || newPos.y < 0)
            {
                return false;
            }

            else if (newPos.x > plats.GetLength(0) || newPos.y > plats.GetLength(1))
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }
        public void UpdatePosition()
        {

        }



    }
}

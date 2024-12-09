using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public  class PlateauSize
    {

       public static  string[,] PlatSize;
        private static PlateauSize instanse = null; 

        private PlateauSize(string[,] platSize) { 
          PlatSize = platSize;
        }
        
        public static PlateauSize GetInstance(string[,] platsize)
        {
            if (instanse == null) { 
                instanse = new PlateauSize(platsize);
                Console.WriteLine($"Created Plateau of size: {platsize.GetLength(0)} {platsize.GetLength(1)}");
            }

            return instanse;
        }
        public void UpdatePlateau(Position pos)
        {
          
          
          int collumnL = (PlatSize.GetLength(0) - pos.y);
            Console.WriteLine(collumnL);
            
            PlatSize[collumnL ,pos.x] = "X";
            Console.WriteLine("Updated Position");
            // adds rover to the Grid
        }

     public   void PopulatePlateau()
        {
       
            for (int i = 0; i <= PlatSize.GetUpperBound(0); i++)
            {
                for(int j = 0;j <= PlatSize.GetUpperBound(1); j++)
                {

                    PlatSize[i, j] = "-";
                    
                   
                }
            }
            //Fills plateau with values
        }

        public void DisplayPlateau()
        {
            for (int i = 0; i <= PlatSize.GetUpperBound(0);i++)
            {

                for (int ii = 0; ii <= PlatSize.GetUpperBound(1); ii++)
                {
                    Console.Write(PlatSize[i, ii]);
                }

               
                Console.WriteLine();
            }

        }

        public  string[,] GetSize()
        {
            return PlatSize;
        }
      
    }
}

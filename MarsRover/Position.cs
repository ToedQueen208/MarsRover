using MarsRover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Position
{
    // Perhaps these should be public auto-properties, perhaps private fields... it's up to you!

    public int x;
   public int y;
    public CompassDirection facing;
    
    public Position(int x, int y, CompassDirection dir)
    {
        this.x = x; 
        this.y = y;
        facing = dir;   
    }
    
    
    // this type can be whatever your direction enum is called
}
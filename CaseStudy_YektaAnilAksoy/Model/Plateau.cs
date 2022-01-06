using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Plateau
    {
        public int x { get; set; }
        public int y { get; set; }

        public Plateau(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public bool isMoveValid(Coordinate coord)
        {
            if(x>= coord.x && coord.x >=0 && y>= coord.y && coord.y >= 0)
            {
                return true;
            }
            return false;
        }
    }
}

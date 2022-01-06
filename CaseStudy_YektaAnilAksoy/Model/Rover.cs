using MarsRover.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Rover
    {
        public Plateau plateau { get; set; }
        public Direction direction { get; set; }

        public Coordinate coordinate { get; set; }

        public Rover(Plateau plateau, Direction direction, Coordinate coordinate)
        {
            this.plateau = plateau;
            this.direction = direction;
            this.coordinate = coordinate;
        }

        public void runInstruction(char inst)
        {
            if(inst == 'L')
            {
                turnLeft();
            }
            else if(inst == 'R')
            {
                turnRight();
            }
            else if(inst == 'M')
            {
                Coordinate previousCoordinate = new Coordinate(coordinate.x,coordinate.y);
                switch (direction)
                {
                    case Direction.N: coordinate.IncrementBy(0, 1); break;
                    case Direction.E: coordinate.IncrementBy(1, 0); break;
                    case Direction.S: coordinate.IncrementBy(0, -1); break;
                    case Direction.W: coordinate.IncrementBy(-1, 0); break;
                    default: break;
                }
                if (!plateau.isMoveValid(coordinate))
                {
                    coordinate = previousCoordinate;
                    
                }
            }
        }

        public void turnLeft()
        {
            if((int)direction == 0)
            {
                direction = Direction.W;
            }
            else
            {
                direction = (Direction)((int)direction - 1);
            }
        }

        public void turnRight()
        {
            if ((int)direction == 3)
            {
                direction = Direction.N;
            }
            else
            {
                direction = (Direction)((int)direction + 1);
            }
        }

        public void print()
        {
            Console.WriteLine(String.Format("Final Coordinate: ({0},{1} {2})", coordinate.x, coordinate.y, direction));
        }
    }
}

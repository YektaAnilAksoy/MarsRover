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

        public void RunInstruction(char inst)
        {
            if(inst == 'L')
            {
                TurnLeft();
            }
            else if(inst == 'R')
            {
                TurnRight();
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

        public void TurnLeft()
        {
            if(direction == Direction.N)
            {
                direction = Direction.W;
            }
            else
            {
                direction = (Direction)((int)direction - 1);
            }
        }

        public void TurnRight()
        {
            if (direction == Direction.W)
            {
                direction = Direction.N;
            }
            else
            {
                direction = (Direction)((int)direction + 1);
            }
        }

        public void Print()
        {
            Console.WriteLine(String.Format("Final Coordinate: ({0},{1} {2})", coordinate.x, coordinate.y, direction));
        }
    }
}

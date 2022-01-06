using MarsRover.Enum;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_YektaAnilAksoy
{
    public class MarsRoverRunner
    {

        public static void Runner(Rover rover, String instructions)
        {
            foreach(char c in instructions)
            {
                rover.RunInstruction(c);
            }
            rover.Print();
        }

        public static void Main(String[] args)
        {
            // First Rover
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, Direction.N, coordinate);

            string instructions = "LMLMLMLMM";
            Runner(rover, instructions);

            // Second Rover
            rover.coordinate = new Coordinate(3, 3);
            rover.direction = Direction.E;
            instructions = "MMRMMRMRRM";
            Runner(rover, instructions);
        }
    }
}

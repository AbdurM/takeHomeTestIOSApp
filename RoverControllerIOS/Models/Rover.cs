using System;
using System.Drawing;
using RoverControllerIOS.Enums;
using RoverControllerIOS.Interfaces;

namespace RoverControllerIOS.Models
{
    public class Rover : IVehicle
    {
        #region Properties

        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Direction { get; private set; }

        #endregion

        #region Constructors

        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        #endregion

        #region Movement related Methods

        public void MoveForward()
        {
           switch (Direction)
            {
                case Direction.North:
                    Y++;
                    break;
                case Direction.South:
                    if (Y > 0)
                        Y--;
                    break;
                case Direction.East:
                    X++;
                    break;
                case Direction.West:
                    if (X > 0)
                        X--;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.West;
                    break;
                case Direction.South:
                    Direction = Direction.East;
                    break;
                case Direction.East:
                    Direction = Direction.North;
                    break;
                case Direction.West:
                    Direction = Direction.South;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.East;
                    break;
                case Direction.South:
                    Direction = Direction.West;
                    break;
                case Direction.East:
                    Direction = Direction.South;
                    break;
                case Direction.West:
                    Direction = Direction.North;
                    break;
            }
        }

        #endregion

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }
        
    }
}

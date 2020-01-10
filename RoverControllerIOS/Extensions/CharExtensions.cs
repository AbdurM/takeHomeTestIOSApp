using System;
using RoverControllerIOS.Enums;

namespace RoverControllerIOS.Extensions
{
    public static class CharExtensions
    {
        public static Movement ToMovementEnum(this char c)
        {
            switch (char.ToUpper(c)) 
            {
                case 'M':
                    return Movement.Move;

                case 'L':
                    return Movement.Left;

                case 'R':
                    return Movement.Right;

                default:
                    throw new Exception("Unrecongnised movement. Please use only M, L or R");
            }
        }
    }
}

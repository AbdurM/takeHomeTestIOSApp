using RoverControllerIOS.Enums;

namespace RoverControllerIOS.Interfaces
{
    public interface IVehicle
    {
        int X { get;}
        int Y { get;}
        Direction Direction {get;}

        void MoveForward();
        void TurnLeft();
        void TurnRight();
    }
}

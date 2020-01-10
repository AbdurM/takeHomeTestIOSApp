using RoverControllerIOS.Enums;

namespace RoverControllerIOS.Interfaces
{
    public interface IVehicle
    {
        int X { get;}
        int Y { get;}
        Direction Direction {get;}

        void Move();
        void TurnLeft();
        void TurnRight();
    }
}

using System;
using RoverControllerIOS.Interfaces;

namespace RoverControllerIOS.ViewModels
{
    public class RoverViewModel
    {
        #region Properties

        IVehicle Rover { get; set; }

        public string XCoordinateText => Rover.X.ToString();
        public string YCoordinateText => Rover.Y.ToString();
        public string DirectionText => Rover.Direction.ToString();

        #endregion

        #region Constructors

        public RoverViewModel(IVehicle rover)
        {
            Rover = rover;
        }

        #endregion

        #region Movement related methods

        public void MoveRoverForward()
        {
            Rover.MoveForward();
        }

        public void TurnRoverLeft()
        {
            Rover.TurnLeft();
        }

        public void TurnRoverRight()
        {
            Rover.TurnRight();
        }

        #endregion
    }
}

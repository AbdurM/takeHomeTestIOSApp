using System;
using RoverControllerIOS.Interfaces;

namespace RoverControllerIOS.ViewModels
{
    public class RoverViewModel
    {
        #region Properties
        public IVehicle Rover { get; private set; }

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

    }
}

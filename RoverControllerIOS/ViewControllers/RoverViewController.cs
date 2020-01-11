using Foundation;
using RoverControllerIOS.Enums;
using RoverControllerIOS.Interfaces;
using RoverControllerIOS.Models;
using RoverControllerIOS.ViewModels;
using System;
using UIKit;

namespace RoverControllerIOS
{
    public partial class RoverViewController : UIViewController
    {
        public RoverViewModel RoverViewModel;

        public RoverViewController(IntPtr handle) : base(handle)
        {
        }


        #region View lifecycle methods

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            MoveButton.TouchUpInside += OnClickMoveButton;
            RightButton.TouchUpInside += OnClickRightButton;
            LeftButton.TouchUpInside += OnClickLeftButton;
        }


        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            MoveButton.TouchUpInside -= OnClickMoveButton;
            RightButton.TouchUpInside -= OnClickRightButton;
            LeftButton.TouchUpInside -= OnClickLeftButton;

        }

        #endregion

        #region Button Actions
        void OnClickMoveButton(object o, EventArgs e)
        {
            RoverViewModel.Rover.Move();
            XCoordinateValueLabel.Text = RoverViewModel.XCoordinateText;
            YCoordinateValueLabel.Text = RoverViewModel.YCoordinateText;
            
        }

        void OnClickRightButton(object o, EventArgs e)
        {
            RoverViewModel.Rover.TurnRight();
            DirectionValueLabel.Text = RoverViewModel.DirectionText;
        }

        void OnClickLeftButton(object o, EventArgs e)
        {
            RoverViewModel.Rover.TurnLeft();
            DirectionValueLabel.Text = RoverViewModel.DirectionText;
        }

        #endregion

    }
}
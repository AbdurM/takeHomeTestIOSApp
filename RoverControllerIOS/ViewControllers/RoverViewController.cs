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

            //setting up initial values of labels
            XCoordinateValueLabel.Text = RoverViewModel.XCoordinateText;
            YCoordinateValueLabel.Text = RoverViewModel.YCoordinateText;
            DirectionValueLabel.Text = RoverViewModel.DirectionText;

            //rounded corners for buttons
            MoveButton.Layer.CornerRadius = Constants.ControlButtonCornerRadius;
            RightButton.Layer.CornerRadius = Constants.ControlButtonCornerRadius;
            LeftButton.Layer.CornerRadius = Constants.ControlButtonCornerRadius;
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
            RoverViewModel.MoveRoverForward();
            XCoordinateValueLabel.Text = RoverViewModel.XCoordinateText;
            YCoordinateValueLabel.Text = RoverViewModel.YCoordinateText;
            
        }

        void OnClickRightButton(object o, EventArgs e)
        {
            RoverViewModel.TurnRoverRight();
            DirectionValueLabel.Text = RoverViewModel.DirectionText;
        }

        void OnClickLeftButton(object o, EventArgs e)
        {
            RoverViewModel.TurnRoverLeft();
            DirectionValueLabel.Text = RoverViewModel.DirectionText;
        }

        #endregion

    }
}
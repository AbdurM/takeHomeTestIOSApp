// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RoverControllerIOS
{
    [Register ("RoverViewController")]
    partial class RoverViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DirectionValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LeftButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MoveButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RightButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel XCoordinateValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel YCoordinateValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DirectionValueLabel != null) {
                DirectionValueLabel.Dispose ();
                DirectionValueLabel = null;
            }

            if (LeftButton != null) {
                LeftButton.Dispose ();
                LeftButton = null;
            }

            if (MoveButton != null) {
                MoveButton.Dispose ();
                MoveButton = null;
            }

            if (RightButton != null) {
                RightButton.Dispose ();
                RightButton = null;
            }

            if (XCoordinateValueLabel != null) {
                XCoordinateValueLabel.Dispose ();
                XCoordinateValueLabel = null;
            }

            if (YCoordinateValueLabel != null) {
                YCoordinateValueLabel.Dispose ();
                YCoordinateValueLabel = null;
            }
        }
    }
}
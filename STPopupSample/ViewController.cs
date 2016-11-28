using System;

using UIKit;
using STPopup;
using CoreGraphics;

namespace STPopupSample
{
    public class ViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;

            var button = new UIButton(new CGRect(20, (View.Bounds.Height / 2) - 22, View.Bounds.Width - 40, 44));
            button.Layer.CornerRadius = 5f;
            button.ClipsToBounds = true;
            button.BackgroundColor = UIColor.Orange;
            button.SetTitle("Click me!", UIControlState.Normal);
            View.AddSubview(button);

            button.TouchUpInside += Button_TouchUpInside;
        }

        void Button_TouchUpInside(object sender, EventArgs e)
        {
            STPopupController popupController = new STPopupController(new PopupViewController(new CGSize(View.Bounds.Width - 40, View.Bounds.Height - 120)));
            popupController.ContainerView.Layer.CornerRadius = 4f;
            popupController.BackgroundView.AddGestureRecognizer(new UITapGestureRecognizer((obj) => popupController.Dismiss()));
            popupController.PresentInViewController(this);
        }
    }
}


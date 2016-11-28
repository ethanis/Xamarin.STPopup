using System;
using CoreGraphics;
using UIKit;
using STPopup;
using Foundation;

namespace STPopupSample
{
    public class PopupViewController : UIViewController
    {
        UIWebView webview;

        public PopupViewController(CGSize size)
        {
            Title = "STPopup";
            this.SetContentSizeInPopup(size);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var size = this.GetContentSizeInPopup();

            webview = new UIWebView(new CGRect(CGPoint.Empty, size));
            webview.LoadRequest(new NSUrlRequest(new NSUrl("https://www.xamarin.com")));
            webview.ScalesPageToFit = true;
            View.AddSubview(webview);
        }
    }
}


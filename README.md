#Xamarin.STPopup#
##Overview##
Xamarin.iOS binding library for [STPopup](https://github.com/kevin0571/STPopup)

##How to get it it##
+ Nuget: [here](https://www.nuget.org/packages/Xamarin.STPopup)
+ Manual build: Download this repo

##How to use it##
In presenting View Controller:
```
STPopupController popupController = new STPopupController(
    new PopupViewController(new CGSize(View.Bounds.Width - 40, 
                                       View.Bounds.Height - 120)));
popupController.ContainerView.Layer.CornerRadius = 4f;
popupController.BackgroundView.AddGestureRecognizer(new UITapGestureRecognizer((obj) => popupController.Dismiss()));
popupController.PresentInViewController(this);
```
In presented View Controller:
```
public PopupViewController(CGSize size)
{
    Title = "STPopup";
    this.SetContentSizeInPopup(size);
}
```
Full demo can be seen in the sample project.
##Issues##
+ Create an issue
+ Create a PR

Enjoy!

using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace STPopup
{
	// @interface STPopupNavigationBar : UINavigationBar
	[BaseType (typeof(UINavigationBar))]
	interface STPopupNavigationBar
	{
		// @property (assign, nonatomic) BOOL draggable;
		[Export ("draggable")]
		bool Draggable { get; set; }
	}

	// @interface STPopupController : NSObject
	[BaseType (typeof(NSObject))]
	interface STPopupController
	{
		// @property (assign, nonatomic) STPopupStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		STPopupStyle Style { get; set; }

		// @property (assign, nonatomic) STPopupTransitionStyle transitionStyle;
		[Export ("transitionStyle", ArgumentSemantic.Assign)]
		STPopupTransitionStyle TransitionStyle { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius __attribute__((deprecated("Use containerView.layer.cornerRadius instead")));
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) BOOL navigationBarHidden;
		[Export ("navigationBarHidden")]
		bool NavigationBarHidden { get; set; }

		// @property (readonly, nonatomic, strong) STPopupNavigationBar * navigationBar;
		[Export ("navigationBar", ArgumentSemantic.Strong)]
		STPopupNavigationBar NavigationBar { get; }

		// @property (nonatomic, strong) UIView * backgroundView;
		[Export ("backgroundView", ArgumentSemantic.Strong)]
		UIView BackgroundView { get; set; }

		// @property (readonly, nonatomic, strong) UIView * containerView;
		[Export ("containerView", ArgumentSemantic.Strong)]
		UIView ContainerView { get; }

		// @property (readonly, nonatomic, strong) UIViewController * topViewController;
		[Export ("topViewController", ArgumentSemantic.Strong)]
		UIViewController TopViewController { get; }

		// @property (readonly, assign, nonatomic) BOOL presented;
		[Export ("presented")]
		bool Presented { get; }

		// -(instancetype)initWithRootViewController:(UIViewController *)rootViewController;
		[Export ("initWithRootViewController:")]
		IntPtr Constructor (UIViewController rootViewController);

		// -(void)presentInViewController:(UIViewController *)viewController;
		[Export ("presentInViewController:")]
		void PresentInViewController (UIViewController viewController);

		// -(void)presentInViewController:(UIViewController *)viewController completion:(void (^)(void))completion;
		[Export ("presentInViewController:completion:")]
		void PresentInViewController (UIViewController viewController, Action completion);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();

		// -(void)dismissWithCompletion:(void (^)(void))completion;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion (Action completion);

		// -(void)pushViewController:(UIViewController *)viewController animated:(BOOL)animated;
		[Export ("pushViewController:animated:")]
		void PushViewController (UIViewController viewController, bool animated);

		// -(void)popViewControllerAnimated:(BOOL)animated;
		[Export ("popViewControllerAnimated:")]
		void PopViewControllerAnimated (bool animated);

		// -(void)setNavigationBarHidden:(BOOL)navigationBarHidden animated:(BOOL)animated;
		[Export ("setNavigationBarHidden:animated:")]
		void SetNavigationBarHidden (bool navigationBarHidden, bool animated);
	}

	// @interface STPopup (UIViewController)
  [Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_STPopup
	{
		[Export ("contentSizeInPopup")]
    CGSize GetContentSizeInPopup();

    [Export ("setContentSizeInPopup:")]
    void SetContentSizeInPopup(CGSize contentSizeInPopup);

    [Export ("landscapeContentSizeInPopup")]
    CGSize GetLandscapeContentSizeInPopup();

    [Export ("setLandscapeContentSizeInPopup:")]
    void SetLandscapeContentSizeInPopup(CGSize landscapeContentSizeInPopup);

    [Export ("getPopupController")]
    STPopupController GetPopupController();
	}

	// @interface STPopupLeftBarItem : UIBarButtonItem
	[BaseType (typeof(UIBarButtonItem))]
	interface STPopupLeftBarItem
	{
		// @property (assign, nonatomic) STPopupLeftBarItemType type;
		[Export ("type", ArgumentSemantic.Assign)]
		STPopupLeftBarItemType Type { get; set; }

		// -(instancetype)initWithTarget:(id)target action:(SEL)action;
		[Export ("initWithTarget:action:")]
		IntPtr Constructor (NSObject target, Selector action);

		// -(void)setType:(STPopupLeftBarItemType)type animated:(BOOL)animated;
		[Export ("setType:animated:")]
		void SetType (STPopupLeftBarItemType type, bool animated);
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const STPopupFirstResponderDidChangeNotification;
		[Field ("STPopupFirstResponderDidChangeNotification", "__Internal")]
		NSString STPopupFirstResponderDidChangeNotification { get; }
	}

	// @interface STPopup (UIResponder)
	[Category]
	[BaseType (typeof(UIResponder))]
	interface UIResponder_STPopup
	{
	}
}

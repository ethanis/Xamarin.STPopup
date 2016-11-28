using System;
using ObjCRuntime;

namespace STPopup
{
	[Native]
	public enum STPopupStyle : ulong
	{
		FormSheet,
		BottomSheet
	}

	[Native]
	public enum STPopupTransitionStyle : ulong
	{
		SlideVertical,
		Fade
	}

	[Native]
	public enum STPopupLeftBarItemType : ulong
	{
		Cross,
		Arrow
	}
}

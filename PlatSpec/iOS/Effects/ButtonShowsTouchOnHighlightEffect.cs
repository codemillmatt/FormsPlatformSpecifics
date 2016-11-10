using System;
using Xamarin.Forms.Platform.iOS;
using PlatSpec.iOS;
using Xamarin.Forms;
using UIKit;

[assembly: ExportEffect(typeof(ButtonShowsTouchOnHighlightEffect), "ButtonShowsTouchOnHighlightEffect"), ResolutionGroupName("codemill")]
namespace PlatSpec.iOS
{
	public class ButtonShowsTouchOnHighlightEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			if (Element is Button == false)
				return;

			var native = Control as UIButton;

			native.ShowsTouchWhenHighlighted = true;
		}

		protected override void OnDetached()
		{
			var native = Control as UIButton;

			native.ShowsTouchWhenHighlighted = false;
		}
	}
}

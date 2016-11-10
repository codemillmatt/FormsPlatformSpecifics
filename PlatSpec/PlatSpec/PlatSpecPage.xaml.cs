using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using PlatSpec.iOSSpecific;

namespace PlatSpec
{
	public partial class PlatSpecPage : ContentPage
	{
		public PlatSpecPage()
		{
			InitializeComponent();

			touchEnabledSwitch.Toggled += (sender, e) =>
			{
				theButton.On<iOS>().SetShowsTouchWhenHighlighted(e.Value);	
			};
		}
	}
}

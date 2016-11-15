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
				// Note right now the button is set to be highlighed always via a property set in XAML remove that first!„„
				theButton.On<iOS>().SetShowsTouchWhenHighlighted(e.Value);	
			};
		}
	}
}

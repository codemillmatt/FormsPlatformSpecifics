using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using System.Linq;


namespace PlatSpec.iOSSpecific
{
	public static class CodeMillButton
	{
		//static Effect highlightEffect;

		public static readonly BindableProperty ShowsTouchWhenHighlightedProperty =
			BindableProperty.Create("ShowsTouchWhenHighlighted", typeof(bool), typeof(CodeMillButton), false, propertyChanging: ShowsTouchWhenHighlightedPropertyChanging);

		public static void SetShowsTouchWhenHighlighted(BindableObject element, bool value)
		{
			element.SetValue(ShowsTouchWhenHighlightedProperty, value);
		}

		public static bool GetShowsTouchWhenHighlighted(BindableObject element)
		{
			return (bool)element.GetValue(ShowsTouchWhenHighlightedProperty);
		}

		public static IPlatformElementConfiguration<iOS, Button> SetShowsTouchWhenHighlighted(this IPlatformElementConfiguration<iOS, Button> config, bool value)
		{
			SetShowsTouchWhenHighlighted(config.Element, value);

			return config;
		}

		public static bool GetShowsTouchWhenHighlighted(this IPlatformElementConfiguration<iOS, Button> config)
		{
			return GetShowsTouchWhenHighlighted(config.Element);
		}

		static void ShowsTouchWhenHighlightedPropertyChanging(BindableObject bindable, object oldValue, object newValue)
		{
			var theButton = bindable as Button;

			// TRUE indicates to turn the effect on
			if ((bool)newValue)
			{
				// If the effect is already there, don't bother adding it
				if (!theButton.Effects.Any(e => e is ShowsTouchEffect))
					theButton.Effects.Add(new ShowsTouchEffect());
			}
			else
			{
				var theEffect = theButton.Effects.FirstOrDefault(e => e is ShowsTouchEffect);

				// Remove the effect if it's there
				if (theEffect != null)
					theButton.Effects.Remove(theEffect);
			}
		}
	}
}

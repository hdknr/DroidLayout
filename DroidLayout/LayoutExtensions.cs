using System;
using System.Linq;


namespace DroidLayout
{
	public static class LayoutExtensions
	{
		public static Android.Graphics.Drawables.ColorDrawable ToDrawable(
			this Android.Graphics.Color color){

			return  new Android.Graphics.Drawables.ColorDrawable (color);
		}

		public static Android.Graphics.Drawables.StateListDrawable ToButtonPressEffect(
			this Android.Graphics.Color color, byte alpha=200
		){

			var pressed = new Android.Graphics.Color (
				color.R, color.G, color.B, alpha);

			var effect = new  Android.Graphics.Drawables.StateListDrawable ();
			effect.AddState (
				new int[]{ Android.Resource.Attribute.StatePressed }, pressed.ToDrawable ());

			effect.AddState (
				Android.Util.StateSet.WildCard.ToArray (), color.ToDrawable ());
			return effect;
		}

	}
}


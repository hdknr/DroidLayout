using System;

namespace DroidLayout
{
	public static class LayoutExtensions
	{
		public static Android.Graphics.Drawables.ColorDrawable ToDrawable(
			this Android.Graphics.Color color){

			return  new Android.Graphics.Drawables.ColorDrawable (color);
		}
	}
}


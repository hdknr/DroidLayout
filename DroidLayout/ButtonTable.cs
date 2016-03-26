
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DroidLayout
{
	[Activity (Label = "ButtonTable")]			
	public class ButtonTable : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here

			var container = new LinearLayout (this) {
				Background=Android.Graphics.Color.Yellow.ToDrawable(),
			};
			SetContentView (container);
		}
	}
}



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
	[Activity (Label = "ContentActivity")]
	public class ContentActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
			SetContentView (Resource.Layout.Content);

			SetupMenu ();

		}
		ListView MenuList {
			get { return FindViewById<ListView>(Resource.Id.MenuList);}}

		protected void SetupMenu()
		{
			var menu = new List<string> {
				"Menue1", "Menue2", "Menue3", "Menue4",
				"Menue5", "Menue6", "Menue7", "Menue8", 
			};

			MenuList.Adapter = new ArrayAdapter<string> (
				this, 
				Android.Resource.Layout.SimpleListItemSingleChoice, 
				menu.Select (r => r).ToList<string> ()
			);
		}
	}
}

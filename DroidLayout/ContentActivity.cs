
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
				"Sign In", "Menue2", "Menue3", "Menue4",
				"Menue5", "Menue6", "Menue7", "Menue8",
			};

			//int item_layout_id = Android.Resource.Layout.SimpleListItemSingleChoice;
			int item_layout_id = Resource.Layout.MenuItem;

			MenuList.Adapter = new ArrayAdapter<string> (
				this, item_layout_id,
				menu.Select (r => r).ToList<string> ()
			);

			MenuList.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				if( menu[e.Position] == "Sign In"){
					StartActivity (
						new Intent (this, typeof(SigninActivity))
					);
				}
			};
		}
	}
}

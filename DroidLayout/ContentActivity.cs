
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
			var menuitem = new Dictionary<string, Intent> {
				{"Sign In", new Intent(this, typeof(SigninActivity))},
			};
			int item_layout_id = Resource.Layout.MenuItem;

			MenuList.Adapter = new ArrayAdapter<string> (
				this, item_layout_id,
				menuitem.Select (r => r.Key).ToList<string> ()
			);

			MenuList.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				var key = MenuList.Adapter.GetItem(e.Position).ToString();
				StartActivity( menuitem[key]);

			};
		}
	}
}

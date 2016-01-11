
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

using Android.Util;		//Log

using System.Threading;	//Timer

namespace DroidLayout
{
	[Activity (Label = "SigninActivity")]			
	public class SigninActivity : Activity
	{
		int interval = 1000;

		protected override void OnCreate (Bundle savedInstanceState)
		{	
			Log.Debug (this.LocalClassName, "OnCreate");

			base.OnCreate (savedInstanceState);

			// Create your application here

			SetContentView (Resource.Layout.Signin);

			var timer = new Timer((o) => RunOnUiThread(() =>{
				Console.WriteLine(DateTime.Now.ToLongTimeString());
			}), null , 0, interval);	

			SignInButton.Click += (object sender, EventArgs e) => {
				timer.Dispose();
				Finish();
			};			
		}

		Button SignInButton {
			get { return FindViewById<Button>(Resource.Id.btnSingIn);}}
		
	}
}


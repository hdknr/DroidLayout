
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
	[Activity (Label = "SigninActivity")]			
	public class SigninActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{	
			base.OnCreate (savedInstanceState);

			// Create your application here

			SetContentView (Resource.Layout.Signin);

			SignInButton.Click += (object sender, EventArgs e) => {
				Finish();
			};			
		}

		Button SignInButton {
			get { return FindViewById<Button>(Resource.Id.btnSingIn);}}
		
	}
}


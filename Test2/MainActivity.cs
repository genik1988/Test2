using Android.App;
using Android.Widget;
using Android.OS;

namespace Test2
{
	[Activity (Label = "Test2", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			Button buttonEvg = FindViewById<Button> (Resource.Id.button1);

			button.Click += delegate {
<<<<<<< HEAD
				button.Text = string.Format ("{0} clicks! Hello from Evgeny and Rich!", count++);
=======
				button.Text = string.Format ("Hello from Evgeny!");
>>>>>>> ce42fa6034654f89bec0aa6cf56655a97f0eba2d
			};
		}
	}
}



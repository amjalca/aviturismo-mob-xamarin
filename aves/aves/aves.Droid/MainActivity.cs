using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace aves.Droid
{
	[Activity (Label = "aves.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            //Referencia al boton que lleva al menu principal
            var botonMostrarMenuPrincipal = FindViewById<ImageButton>(Resource.Id.imageButton1);

            botonMostrarMenuPrincipal.Click += (sender, e) => {
                var menuPrincipal = new Intent(this, typeof(MenuPrincipal));
                StartActivity(menuPrincipal);
            };


        }
	}
}



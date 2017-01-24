using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace Aves.Droid
{
	[Activity (Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/ic_launcher")]
	public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            var ibtnMSgte = FindViewById<ImageButton>(Resource.Id.ibtnMainSgte);
            ibtnMSgte.Click += (sender, e) => {
                var menuInicioA = new Intent(this, typeof(SMMenuActivity));
                StartActivity(menuInicioA);
            };
        }
        
    }

}



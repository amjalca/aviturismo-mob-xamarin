using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Aves.Droid
{
	[Activity (Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/ic_launcher")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Menu);

            var ibtnEquipos = FindViewById<ImageButton>(Resource.Id.ibtnMnEqui);            
            ibtnEquipos.Click += (sender, e) => {
                var subMenuEquipos = new Intent(this, typeof(SMEquiposActivity));
                StartActivity(subMenuEquipos);
            };

            var ibtnRecomendaciones = FindViewById<ImageButton>(Resource.Id.ibtnMnReco);
            ibtnRecomendaciones.Click += (sender, e) => {
                var subMenuRecomendaciones = new Intent(this, typeof(SMRecomendacionesActivity));
                StartActivity(subMenuRecomendaciones);
            };

            var ibtnTipos = FindViewById<ImageButton>(Resource.Id.ibtnMnTipo);
            ibtnTipos.Click += (sender, e) => {
                var subMenuTipos = new Intent(this, typeof(SMTiposActivity));
                StartActivity(subMenuTipos);
            };

            var ibtnMorfologia = FindViewById<ImageButton>(Resource.Id.ibtnMnMorf);
            ibtnMorfologia.Click += (sender, e) => {
                var subMenuMorfologia = new Intent(this, typeof(SMMorfologiaActivity));
                StartActivity(subMenuMorfologia);
            };
        }

        
    }

}



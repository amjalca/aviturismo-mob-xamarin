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

namespace aves.Droid
{
    [Activity(Label = "Menu Principal")]
    public class MenuPrincipal : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.MenuPrincipal);

            var botonEquipos = FindViewById<ImageButton>(Resource.Id.opcionEquipos);

            botonEquipos.Click += (sender, e) => {
                var equiposVentana = new Intent(this, typeof(Equipos));
                StartActivity(equiposVentana);
            };


        }
    }
}
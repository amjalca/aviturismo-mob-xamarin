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

namespace Aves.Droid
{
    [Activity(Label = "Menú")]
    public class SMMenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);

            //Botones del menu
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

            //ImageView
            //ImageButton botonP = (ImageButton)FindViewById(Resource.Id.ibtnMnEqui);
            //Bitmap image = BitmapFactory.DecodeResource(Resource.Drawable.ic_equipos);
        
    }
}
}
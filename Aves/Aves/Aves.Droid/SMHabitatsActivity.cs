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
    [Activity(Label = "Hábitats")]
    public class SMHabitatsActivity : Activity
    {
        TabHost th;
        TabHost.TabSpec spec;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SMHabitats);

            th = (Android.Widget.TabHost)FindViewById(Resource.Id.tabHost1);
            th.Setup();
            spec = th.NewTabSpec("linearLayout2");
            spec.SetContent(Resource.Id.lLAHabitats);
            spec.SetIndicator("Aprender");
            th.AddTab(spec);
            
            spec = th.NewTabSpec("linearLayout2");
            spec.SetContent(Resource.Id.lLEHabitats);
            spec.SetIndicator("Evaluar");
            th.AddTab(spec);
            //Aprender Habitats
            var gvwAHabitats = (Android.Widget.GridView)FindViewById(Resource.Id.gridViewAHabitats);
            gvwAHabitats.Adapter = new ImageAdapter(this);

            gvwAHabitats.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };

            //Evaluar Habitats
            var gvwEHabitats = (Android.Widget.GridView)FindViewById(Resource.Id.gridViewEHabitats);
            gvwEHabitats.Adapter = new ImageAdapter(this);

            gvwEHabitats.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };

            //var ibtnAHCostas = gvwAHabitats.GetItemId(args.Position);
            //ibtnAHCostas.Click += InfoClickReco;
        }

        //void InfoClickReco(object sender, EventArgs e)
        //{
        //    Android.App.AlertDialog.Builder builder = new AlertDialog.Builder(this);
        //    AlertDialog alerD = builder.Create();
        //    alerD.SetTitle("Recomendaciones");
        //    alerD.SetIcon(Resource.Drawable.ic_recomendaciones);
        //    alerD.SetMessage("- Es necesario cumplir con los reglamentos de los parques y áreas naturales.\n- No dejar basura, el ave puede ingerirla y morir si llega a comerla.\n- Procurar estar en los caminos o veredas.\n- Dividirse en grupos pequeños, así habrá menos desorden.\n- No molestar a las aves sobre todo si están anidando.\n- Nunca tome los huevos o polluelos de las aves.\n- Disfruta y déjese encantar por lo que va aprendiendo en el recorrido.");
        //    alerD.SetButton("Ok", (s, ev) => { });
        //    alerD.Show();
        //}
    }
}
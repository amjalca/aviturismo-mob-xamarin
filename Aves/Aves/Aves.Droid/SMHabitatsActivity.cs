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
        }
    }
}
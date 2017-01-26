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
    [Activity(Label = "Sonidos")]
    public class SMSonidoActivity : Activity
    {
        TabHost thS;
        TabHost.TabSpec specS;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SMSonido);

            thS = (Android.Widget.TabHost)FindViewById(Resource.Id.tabHost2);
            thS.Setup();
            specS = thS.NewTabSpec("linearLayout2");
            specS.SetContent(Resource.Id.lLASonido);
            specS.SetIndicator("Aprender");
            thS.AddTab(specS);

            specS = thS.NewTabSpec("linearLayout2");
            specS.SetContent(Resource.Id.lLESonido);
            specS.SetIndicator("Evaluar");
            thS.AddTab(specS);
            //Aprender Habitats
            var gvwASonido = (Android.Widget.GridView)FindViewById(Resource.Id.gridViewASonido);
            gvwASonido.Adapter = new ImageAdapterS(this);

            //gvwASonido.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            //{
            //    Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            //};

        }
    }
}
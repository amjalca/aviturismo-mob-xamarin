using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Aves.Droid
{
    [Activity(Label = "Tipos de aves")]
    public class SMTiposActivity : TabActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SMTipos);

            CreateTab(typeof(TabATiposActivity), "a_tipos_on", "Aprender", Resource.Drawable.ic_tab_tipos_aprender_on);
            CreateTab(typeof(TabETiposActivity), "e_tipos", "Evaluar", Resource.Drawable.ic_tab_tipos_evaluar);
                        
        }




        private void CreateTab(Type activityType, string tag, string label, int drawableId)
        {
            var intent = new Intent(this, activityType);
            intent.AddFlags(ActivityFlags.NewTask);

            var spec = TabHost.NewTabSpec(tag);
            //ContextCompat.getDrawable(getActivity(), R.drawable.name);
            var drawableIcon = Resources.GetDrawable(drawableId);
            spec.SetIndicator(label, drawableIcon);
            spec.SetContent(intent);

            TabHost.AddTab(spec);
        }
    }
}
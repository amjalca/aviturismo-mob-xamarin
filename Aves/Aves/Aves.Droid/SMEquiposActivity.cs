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
    [Activity(Label = "Equipo necesario")]
    public class SMEquiposActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SMEquipo);



            var ibtnBinoculares = FindViewById<ImageButton>(Resource.Id.ibtnSmBino);
            ibtnBinoculares.Click += InfoClickBino;
        }

        void InfoClickBino(object sender, EventArgs e)
        {
            Android.App.AlertDialog.Builder builder = new AlertDialog.Builder(this);
            AlertDialog alerD = builder.Create();
            alerD.SetTitle("Binoculares");
            alerD.SetIcon(Resource.Drawable.ic_binocular);
            alerD.SetMessage("- Para comprobar un correcto aumento en lo binoculares, debe ver a simple vista las bandas de la cola de una aguililla a 50 metros.\n- Los aumentos recomendables son 7X, 8X, 9X y 10X.\n- Mayores a 10, serán pocos prácticos por el aumento de peso y amplificación de las vibraciones.\n- Tiene que considerar si puede cargar en su cuello los binoculares por más de 5 horas.\n- Cuidelos del golpe, la suciedad, el sol y el agua.\n- Limpiarlos con paños húmedos, o secarlos de la lluvia lo más pronto.");
            alerD.SetButton("Ok", (s, ev) => { });
            alerD.Show();
        }
    }
}
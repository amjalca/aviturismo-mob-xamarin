using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Aves.Droid
{
    public class ImageAdapterS : BaseAdapter
    {
        private readonly Context context;

        public ImageAdapterS(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return imgSonidoIds.Length; }
        }

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {
                // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.LayoutParameters = new AbsListView.LayoutParams(300, 250);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(1, 4, 1, 4);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(imgSonidoIds[position]);
            return imageView;
        }

        // references to our images
        private readonly int[] imgSonidoIds = {
                                              Resource.Drawable.cacique_lomiamarillo,
                                              Resource.Drawable.zanate_matorralero,
                                              Resource.Drawable.cerceta_aliazul,
                                          };
    }
}
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Aves.Droid
{
    public class ImageAdapter : BaseAdapter
    {
        private readonly Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return imgHabitatsIds.Length; }
        }

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {
                // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.LayoutParameters = new AbsListView.LayoutParams(200, 200);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(1, 4, 1, 4);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(imgHabitatsIds[position]);
            return imageView;
        }

        // references to our images
        private readonly int[] imgHabitatsIds = {
                                              Resource.Drawable.costa, Resource.Drawable.desierto,
                                              Resource.Drawable.pastizal, Resource.Drawable.bosque,
                                              Resource.Drawable.selva, Resource.Drawable.lago,
                                          };
    }
}
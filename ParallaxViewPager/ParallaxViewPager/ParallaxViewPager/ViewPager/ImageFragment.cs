using System;
using Android.App;
using Android.Views;
using Android.OS;
using Android.Widget;
using Android.Graphics;
using Android.Support.V4.View;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using Android.Content;

namespace ParallaxViewPager
{
    public class ImageFragment : Fragment
    {
        private Item _campaign;
        private Activity _context;
        private string _imageUrl;

        public ImageFragment(Activity context, Item campaign)
        {
            _context = context;
            _campaign = campaign;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var v = inflater.Inflate(Resource.Layout.CampaignImage, container, false);
            var imgButton = v.FindViewById<ImageButton>(Resource.Id.imageButton1);

            float density = _context.Resources.DisplayMetrics.Density;
            imgButton.LayoutParameters.Width = (int)(ScreenUtils.ScreenWidth + ScreenUtils.ScreenWidth / density);

            imgButton.SetImageDrawable(GetDrawable(_campaign.ImageUrl));
            return v;
        }

        private Drawable GetDrawable(String name)
        {
            Context context = this.Activity;
            int resourceId = context.Resources.GetIdentifier(name.Replace(".jpg", ""), "drawable", context.PackageName);
            return context.Resources.GetDrawable(resourceId);
        }
    }
}


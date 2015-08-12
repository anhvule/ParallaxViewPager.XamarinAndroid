using System;
using Android.Views;

namespace ParallaxViewPager
{
    public class ParallaxPageTransformer : BaseJavaObject, Android.Support.V4.View.ViewPager.IPageTransformer
    {
        private const float SPEED_SCROLLING = 0.2f;

        public void TransformPage(View view, float position)
        {
            var imgButton = view.FindViewById(Resource.Id.imageButton1);
            imgButton.SetX(position * SPEED_SCROLLING);
            imgButton.SetY(0);

            if (position > -1 && position < 1)
            {
                float width = imgButton.Width;
                imgButton.TranslationX = (-(position * width * SPEED_SCROLLING));
            }
        }
    }
}


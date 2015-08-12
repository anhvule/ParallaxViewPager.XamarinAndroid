using System;
using Android.Graphics;
using System.Collections.Generic;
using Android.Widget;

namespace ParallaxViewPager
{
    public static class ScreenUtils
    {
        private static int _screenWidth, _screenHeight;

        static ScreenUtils()
        {
            Point size = new Point();
            MainActivity.Context.WindowManager.DefaultDisplay.GetSize(size);
            _screenWidth = size.X;
            _screenHeight = size.Y;
        }

        public static int ScreenWidth
        {
            get
            {
                return _screenWidth;
            }
        }

        public static int ScreenHeight
        {
            get
            {
                return _screenHeight;
            }
        }
    }
}


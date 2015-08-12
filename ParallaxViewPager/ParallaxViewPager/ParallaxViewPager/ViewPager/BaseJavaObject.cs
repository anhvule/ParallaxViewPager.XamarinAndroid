using System;
using Android.Runtime;

namespace ParallaxViewPager
{
    public class BaseJavaObject : Java.Lang.Object
    {
        public IntPtr Handle
        {
            get { return ((Java.Lang.Object)this).Handle; }
        }

        public void Dispose()
        {
            ((IJavaObject)this).Dispose();
        }
    }
}


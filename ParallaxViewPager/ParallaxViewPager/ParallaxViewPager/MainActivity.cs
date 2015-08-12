using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;

namespace ParallaxViewPager
{
    [Activity(Label = "ParallaxViewPager", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private static Activity _context;
        private ViewPagerAdapter _adapter;
        private ViewPager _pager;

        public static Activity Context
        {
            get
            {
                return MainActivity._context;
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MainMenuForGuest);

            _context = this;

            _pager = FindViewById<ViewPager>(Resource.Id.pager);
            _adapter = new ViewPagerAdapter(this, FragmentManager);

            _pager.SetPageTransformer(true, new ParallaxPageTransformer());
            _pager.Adapter = _adapter;
            _adapter.ViewPager = _pager;

            ViewPagerChangeListener pageChangeListener = new ViewPagerChangeListener(_pager, delegate(int position, int positionOffsetPixels)
                {
                    // Write something
                });

            _pager.AddOnPageChangeListener(pageChangeListener);

            _adapter.Campaigns = ItemFactory.Create();
            _pager.SetCurrentItem(1, false);
        }
    }
}



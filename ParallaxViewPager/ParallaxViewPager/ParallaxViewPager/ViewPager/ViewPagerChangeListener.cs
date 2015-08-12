using System;
using Android.Support.V4.View;

namespace ParallaxViewPager
{
    public class ViewPagerChangeListener : BaseJavaObject, Android.Support.V4.View.ViewPager.IOnPageChangeListener
    {
        private ViewPager _pager;

        public Action<int, int> OnViewPagerScrolled { get; set; }

        public ViewPagerChangeListener(ViewPager pager, Action<int, int> onViewPagerScrolled)
        {
            _pager = pager;
            OnViewPagerScrolled = onViewPagerScrolled;
        }

        public void OnPageScrollStateChanged(int state)
        {
            if (state == ViewPager.ScrollStateIdle)
            {
                int index = _pager.CurrentItem;
                if (index == 0)
                {
                    _pager.SetCurrentItem(_pager.Adapter.Count - 2, false);
                }
                else if (index == _pager.Adapter.Count - 1)
                {
                    _pager.SetCurrentItem(1, false);
                }
            }
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            if (position <= 0)
            {
                position = (_pager.Adapter.Count - 2) - 1;
            }
            else if (position > _pager.Adapter.Count - 2)
            {
                position = 0;
            }
            else
            {
                position--;
            } 

            if (OnViewPagerScrolled != null)
            {
                OnViewPagerScrolled(position, positionOffsetPixels);
            }
        }

        public void OnPageSelected(int position)
        {

        }
    }
}


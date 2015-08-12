using System;
using Android.App;
using Android.Support.V13.App;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Android.Support.V4.View;

namespace ParallaxViewPager
{
    public class ViewPagerAdapter : FragmentStatePagerAdapter
    {
        private Activity _context;
        private ObservableCollection<Item> _campaigns = new ObservableCollection<Item>();

        public ViewPager ViewPager { get; set; }

        public ObservableCollection<Item> Campaigns
        {
            set
            {
                if (value == null)
                {
                    return;
                }

                if (_campaigns != null)
                {
                    _campaigns.Clear();
                }

                if (value.Count > 1)
                {
                    _campaigns.Add(value[value.Count - 1]);
                    foreach (var campaign in value)
                    {
                        _campaigns.Add(campaign);
                    }

                    _campaigns.Add(value[0]);
                }
                else if (value.Count == 1)
                {
                    _campaigns.Add(value[0]);
                }

                NotifyDataSetChanged();
            }
            get
            {
                return _campaigns;
            }
        }

        public ViewPagerAdapter(Activity context, FragmentManager fm)
            : base(fm)
        {
            Campaigns = new ObservableCollection<Item>();
            _context = context;
        }

        public override int Count
        {
            get
            {
                return Campaigns.Count;
            }
        }

        public override Fragment GetItem(int position)
        {
            position = position % Campaigns.Count; // use modulo for infinite cycling
            return new ImageFragment(_context, Campaigns[position]);
        }
    }
}


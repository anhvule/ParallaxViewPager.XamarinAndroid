using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ParallaxViewPager
{
    public class ItemFactory
    {
        private static ObservableCollection<string> _campaignImages = new ObservableCollection<string>()
        {
            "image1.jpg",
            "image2.jpg",
            "image3.jpg",
            "image4.jpg",
            "image5.jpg",
        };

        public static ObservableCollection<Item> Create()
        {
            ObservableCollection<string> campaignImages = _campaignImages;

            var list = new ObservableCollection<Item>();
            for (int i = 0; i < campaignImages.Count; i++)
            {
                list.Add(new Item()
                    {
                        ImageUrl = campaignImages[i],
                    });
            }

            return list;
        }
    }
}


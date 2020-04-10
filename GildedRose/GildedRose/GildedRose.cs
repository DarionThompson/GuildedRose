﻿using System;
using System.Collections.Generic;

namespace Katas
{
	public class GildedRose
	{
		private static IList<Item> _items = null;

        public GildedRose(List<Item> items)
        {
			_items = items;
        }

		public void updateQuality()
		{
			for (int i = 0; i < _items.Count; i++)
			{
				if ((!"Aged Brie".Equals(_items[i].Name)) && !"Backstage passes to a TAFKAL80ETC concert".Equals(_items[i].Name))
				{
					if (_items[i].Quality > 0)
					{
						if (!"Sulfuras, Hand of Ragnaros".Equals(_items[i].Name))
						{
							_items[i].Quality = _items[i].Quality - 1;
						}
					}
				}
				else
				{
					if (_items[i].Quality < 50)
					{
						_items[i].Quality = _items[i].Quality + 1;

						if ("Backstage passes to a TAFKAL80ETC concert".Equals(_items[i].Name))
						{
							if (_items[i].SellIn < 11)
							{
								if (_items[i].Quality < 50)
								{
									_items[i].Quality = (_items[i].Quality + 1);
								}
							}

							if (_items[i].SellIn < 6)
							{
								if (_items[i].Quality < 50)
								{
									_items[i].Quality = (_items[i].Quality + 1);
								}
							}
						}
					}
				}

				if (!"Sulfuras, Hand of Ragnaros".Equals(_items[i].Name))
				{
					_items[i].SellIn = (_items[i].SellIn - 1);
				}

				if (_items[i].SellIn < 0)
				{
					if (!"Aged Brie".Equals(_items[i].Name))
					{
						if (!"Backstage passes to a TAFKAL80ETC concert".Equals(_items[i].Name))
						{
							if (_items[i].Quality > 0)
							{
								if (!"Sulfuras, Hand of Ragnaros".Equals(_items[i].Name))
								{
									_items[i].Quality = (_items[i].Quality - 1);
								}
							}
						}
						else
						{
							_items[i].Quality = (_items[i].Quality - _items[i].Quality);
						}
					}
					else
					{
						if (_items[i].Quality < 50)
						{
							_items[i].Quality = (_items[i].Quality + 1);
						}
					}
				}
			}
		}
	}
}

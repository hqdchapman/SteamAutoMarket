﻿using System;

namespace SteamAutoMarket.Steam.Market.Models
{
    public class PriceHistoryItem
    {
        public DateTime DateTime { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
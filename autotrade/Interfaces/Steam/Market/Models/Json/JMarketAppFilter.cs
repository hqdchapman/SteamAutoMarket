﻿using Newtonsoft.Json;

namespace Market.Models.Json
{
    public class JMarketAppFilter<T> : JSuccess
    {
        public T Facets { get; set; }
    }
}
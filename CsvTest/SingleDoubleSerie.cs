﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PreprocessHistoricalPriceData
{
    public class SingleDoubleSerie : IIndicatorSerie
    {
        public List<double?> Values { get; set; }

        public SingleDoubleSerie()
        {
            Values = new List<double?>();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PreprocessHistoricalPriceData
{
    public class RSISerie : IIndicatorSerie
    {
        public List<double?> RSI { get; set; }
        public List<double?> RS { get; set; }

        public RSISerie()
        {
            RSI = new List<double?>();
            RS = new List<double?>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PreprocessHistoricalPriceData
{
    class DataRecord
    {
        /*
        public String CommonName { get; set; }
        public String FormalName { get; set; }
        public String TelephoneCode { get; set; }
        public String CountryCode { get; set; }
        */
        public String Marker { get; set; }

        public String Date { get; set; }

        public String Time { get; set; }

        public String Last { get; set; }

        public String Volume { get; set; }

    }
}

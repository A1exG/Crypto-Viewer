using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoViewer.Library.Models
{
    public class CurrencyLimit
    {
        public string symbol1 { get; set; }
        public string symbol2 { get; set; }
        public int minLotSize { get; set; }
        public int minLotSizeS2 { get; set; }
        public int maxLotSize { get; set; }
        public string minPrice { get; set; }
        public string maxPrice { get; set; }
    }
}

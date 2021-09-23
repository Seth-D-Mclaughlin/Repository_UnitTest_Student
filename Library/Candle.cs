using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Candle
    {
        public Candle()
        {

        }

        public Candle(string scent, decimal netWeightOunces)
        {
            Scent = scent;
            NetWeightOunces = netWeightOunces;
        }

        public int Id { get; set; }
        public string Scent { get; set; }
        public decimal NetWeightOunces { get; set; }
    }
}

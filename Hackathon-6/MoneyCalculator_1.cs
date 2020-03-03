using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6
{
    class MoneyCalculator_1
    {
        private decimal _remainder;

        public decimal GetParkingFee(decimal income)
        {
            _remainder = income;
            return GetPeriodHalf(10310000) * 0.5M + GetPeriodHalf(4530000) * 0.4M + GetPeriodHalf(2420000) * 0.3M + GetPeriodHalf(1210000) * 0.2M + GetPeriodHalf(540000) * 0.12M + _remainder * 0.05M;
        }
        private decimal GetPeriodHalf(decimal period)
        {
            var result = _remainder - period;
            if (result < 0)
            { result = 0; }
            _remainder -= result;
            return result;
        }

        //public static decimal GetParkingFee(decimal minutes)
        //{
        //    var total = GetHalfHours(minutes);
        //    decimal p50 = GetPeriodHalfHours(total, 10310000);
        //    decimal p40 = GetPeriodHalfHours(total - p50, 4530000);
        //    decimal p30 = GetPeriodHalfHours(total - p50 - p40, 2420000);
        //    decimal p20 = GetPeriodHalfHours(total - p50 - p40 - p30, 1210000);
        //    decimal p12 = GetPeriodHalfHours(total - p50 - p40 - p30 -p20, 540000);
        //    decimal p5 = total - p50 - p40 - p30 - p20-p12;

        //    return p50 * 0.5M + p40 * 0.4M + p30 * 0.3M+ p20 *0.2M + p12*0.12M+p5*0.5M;
        //}

        //private static decimal GetHalfHours(decimal minutes)
        //{
        //    return minutes;
        //}

        //private static decimal GetPeriodHalfHours(decimal remainder, decimal period)
        //{
        //    var result = remainder - period;
        //    if (result < 0)
        //    { return 0; }
        //    return result;
        //}
    }
}

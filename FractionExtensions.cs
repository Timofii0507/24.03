using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class FractionExtensions
    {
        public static Fraction MinFraction(this Fraction[] fractions)
        {
            Fraction minFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if ((double)fraction.Numerator / fraction.Denominator < (double)minFraction.Numerator / minFraction.Denominator)
                {
                    minFraction = fraction;
                }
            }
            return minFraction;
        }

        public static Fraction MaxFraction(this Fraction[] fractions)
        {
            Fraction maxFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if ((double)fraction.Numerator / fraction.Denominator > (double)maxFraction.Numerator / maxFraction.Denominator)
                {
                    maxFraction = fraction;
                }
            }
            return maxFraction;
        }
    }
}

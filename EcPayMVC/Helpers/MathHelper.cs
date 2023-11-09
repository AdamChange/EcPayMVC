using System.Text;

namespace EcPayMVC.Helpers
{
    public static class MathHelper
    {
        public static double GetRoundNum (this double num, int decimalPoint = 0)
        {
            var roundingNum = Math.Round(num, decimalPoint, MidpointRounding.AwayFromZero);
            return roundingNum;
        }
    }

}

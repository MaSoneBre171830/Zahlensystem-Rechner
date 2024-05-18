using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensystemumrechner
{
    public class Zahlensystem
    {
        public string Add(string num1, string num2, int baseNum)
        {
            int result = ToDec(num1, baseNum) + ToDec(num2, baseNum);
            return ConvertFromDecimal(result, baseNum);
        }

        public string Sub(string num1, string num2, int baseNum)
        {
            int result = ToDec(num1, baseNum) - ToDec(num2, baseNum);
            return ConvertFromDecimal(result, baseNum);
        }

        public string Mult(string num1, string num2, int baseNum)
        {
            int result = ToDec(num1, baseNum) * ToDec(num2, baseNum);
            return ConvertFromDecimal(result, baseNum);
        }

        public string Div(string num1, string num2, int baseNum)
        {
            int result = ToDec(num1, baseNum) / ToDec(num2, baseNum);
            return ConvertFromDecimal(result, baseNum);
        }

        // Umrechnungsmethoden
        public string ConvertToBinary(string num, int baseNum)
        {
            int decimalNum = ToDec(num, baseNum);
            return Convert.ToString(decimalNum, 2);
        }

        public string ConvertToOctal(string num, int baseNum)
        {
            int decimalNum = ToDec(num, baseNum);
            return Convert.ToString(decimalNum, 8);
        }

        public string ConvertToDecimal(string num, int baseNum)
        {
            return Convert.ToInt32(num, baseNum).ToString();
        }

        public string ConvertToHexadecimal(string num, int baseNum)
        {
            int decimalNum = ToDec(num, baseNum);
            return Convert.ToString(decimalNum, 16).ToUpper();
        }

        private int ToDec(string num, int baseNum)
        {
            return Convert.ToInt32(num, baseNum);
        }

        private string ConvertFromDecimal(int num, int baseNum)
        {
            return Convert.ToString(num, baseNum).ToUpper();
        }
    }
}

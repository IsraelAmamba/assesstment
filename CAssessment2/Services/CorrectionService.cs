using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace CAssessment2.Services{    public class CorrectionService : ICorrectionService    {        public int MyAtoi(string str)        {            StringBuilder stringBuilder = new StringBuilder();
            //trim the string
            str = str.TrimStart();
            var isPositive = true;

            //convert to character array
            var charArray = str.ToCharArray();            var counter = 0;
            var hasSignAtStart = false;

            foreach (var ch in charArray)            {                ++counter;                if (counter == 1 && (ch == '-' || ch == '+'))                {                    stringBuilder.Append(ch.ToString());                    hasSignAtStart = true;                }                else if (string.IsNullOrWhiteSpace(ch.ToString()))                    break;                else if (int.TryParse(ch.ToString(), out int result))                {                    stringBuilder.Append(result.ToString());                }
                else                    break;            }                        var finalString = stringBuilder.ToString();            if (hasSignAtStart && finalString.Length == 1)                return 0;            else if(finalString.Length == 0)                return 0;            var value = Math.Clamp(Int64.Parse(finalString), int.MinValue, int.MaxValue);            return int.Parse(value.ToString());        }    }}
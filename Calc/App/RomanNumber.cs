using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Calc.App
{
    //Class which works with roman numbers 
    public class RomanNumber
    {
        // Receiving the number from string record
        public static int Parse(String str)
        {
            var RomeNumbers = new Dictionary<char, int>()
                {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
                };
            //If next number is bigger than current, it's currentnumber-result, else need to add this one
            // IX : -1 + 10;  XC : -10 + 100;  XX : +10+10; CX : +100+10
            //
            if (str.Contains('N') && str.Length - 1 != 0)//Проверка на наличие более одного 'N'
            {
                throw new ArgumentException("Invalid number, only one 'N'");
            }
            int result = 0;
            result += RomeNumbers[str[str.Length - 1]];
            for (int i = str.Length - 2; i >= 0;i--) {
                if (RomeNumbers[str[i]] >= RomeNumbers[str[i+1]])
                {
                    result += RomeNumbers[str[i]];

                }
                else if (RomeNumbers[str[i]] < RomeNumbers[str[i+1]])
                { 
                result-=RomeNumbers[str[i]];
                }

            }
            return result;
        }
        public static string ReverseParse(int num) {
            var RomeNumbers = new Dictionary<string, int>()
                {
                {"I", 1},
                {"II", 2},
                {"III", 3},
                {"IV", 4},
                {"V", 5},
                {"VI", 6},
                {"VII", 7},
                {"IIX", 8},
                {"IX", 9},
                {"X", 10},
                {"XL", 40},
                {"L", 50},
                {"XC", 90},
                {"C", 100},
                {"CD", 400},
                {"D", 500},
                {"DM", 900},
                {"M", 1000},
                };
            string result = "";
            //4154 = 4000+100+50+4
            //4000 = 1000+1000+1000+1000
            
          /*  string temp = num.ToString();
            for (int i = temp.Length - 1; i >=0 ; i--) {
                if (i == temp.Length - 1)
                {
                    result += RomeNumbers[temp[i].ToString()];
                    temp[i] = '0';
                    num =
                }
                if (rome)


            }
            
            return result;
        }

        public static string CalculateRomeNumbers(String str1, String str2, char act) {
            int result = 0;
            switch (act)
            {
                case '+': result = Parse(str1)+Parse(str2); break;
                case '-': result = Parse(str1)-Parse(str2); break;
                case '*': result = Parse(str1)*Parse(str2); break;
                case '/': result = Parse(str1)/Parse(str2); break;
                
                default:
                    return "-1";
            }
            

            return ReverseParse(result);
        }
    }
}

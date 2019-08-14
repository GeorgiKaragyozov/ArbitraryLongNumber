using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArbitraryLongNumber
{
    enum Mark
    {
        Plus,
        Minus
    }

    public class ArbitraryLong
    {
        string _number = "0";

        Mark mark = Mark.Plus;

        Regex regex = new Regex("^[0-9]+$");
        
        public string Value
        {
            get
            {
                if (mark == Mark.Plus)
                {
                    return this._number;
                }
                else
                {
                    return "-" + this._number;
                }
            }
            set
            {
                if (!regex.IsMatch(value))
                {
                    if (value.Length > 0 && value[0] == '-')
                    {
                        this.mark = Mark.Minus;
                        this._number = value.ToString().Substring(1);
                    }
                    else
                    {
                        this.mark = Mark.Plus;
                        this._number = value;
                    }
                }
                else
                {
                    throw new Exception("Please enter numbers only .");
                }               
            }
        }

        public ArbitraryLong(string number)
        {
            if(number == "")
            {
                number = "0";
            }

            this._number = number;
            
            if (!(regex.IsMatch(number) || 
                regex.IsMatch(number.Substring(1)) && ((number[0] == '-') || (number[0] == '+'))))
            {
                throw new Exception("Please enter numbers only .");
            }

            if (number == "")
            {
                this._number = "0";
            }
            else
            {             
                if (number[0] == '-')
                {
                    this.mark = Mark.Minus;
                    this._number = number.Substring(1);
                }
                else
                {
                    this._number = number;
                }             
            }
        }

        public ArbitraryLong()
        {

        }

        private static string Reverse(string s)
        {
            //remove zero in the beginning of number
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static int CompareAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num1._number.Length > num2._number.Length)
            {
                return 1;
            }
            else if (num1._number.Length < num2._number.Length)
            {
                return -1;
            }
            else
            {
                string number1 = num1._number;
                string number2 = num2._number;

                for (int i = 0; i < num1._number.Length; i++)
                {
                    if(number1[i] >= number2[i])
                    {
                        return 1;
                    }
                    else if (number1[i] <= number2[i])
                    {
                        return -1;
                    }
                }

                return 1;
            }
        }

        private static int CompareAbsDivision(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num1._number.Length > num2._number.Length)
            {
                return 1;
            }
            else if (num1._number.Length < num2._number.Length)
            {
                return -1;
            }
            else
            {
                string number1 = num1._number;
                string number2 = num2._number;

                for (int i = 0; i < num1._number.Length; i++)
                {
                    if (number1[i] > number2[i])
                    {
                        return 1;
                    }
                    else if (number1[i] < number2[i])
                    {
                        return -1;
                    }
                }

                return 1;
            }
        }

        private static int Compare(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num1.Value == num2.Value)
            {
                return 0;
            }
            else if(num1.mark == Mark.Plus && num2.mark == Mark.Plus)
            {
                return CompareAbs(num1, num2);
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus)
            {
                return 1;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus)
            {
                return 1;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus)
            {
                return CompareAbs(num2, num1);
            }
            else return 0;
        }

        private static int[] ArbitraryLongToIntArray(ArbitraryLong number)
        {
            int[] output = new int[number._number.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Convert.ToInt32(number._number[number._number.Length - 1 - i].ToString());
            }

            return output;
        }

        private static ArbitraryLong AdditionAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            //Convert the two numbers to array of shorts
            int n = num1._number.Length;
            int m = num2._number.Length;
            int[] number1 = ArbitraryLongToIntArray(num1);
            int[] number2 = ArbitraryLongToIntArray(num2);

            //Begin Addition
            int shorterNumber = Math.Min(m, n);
            int longerNumber = Math.Max(m, n);
            int naum = 0;

            int[] result = new int[longerNumber + 1];

            //Add matching numbers
            for (int i = 0; i < shorterNumber; i++)
            {          
                if (number1[i] + number2[i] < 10)
                {
                    result[i] = number1[i] + number2[i] + naum;
                    naum = 0;

                    if(result[i] == 10)
                    {
                        result[i] = 0;
                        naum = 1;
                    }
                }
                else
                {
                    result[i] = (number1[i] + number2[i]) % 10 + naum;
                    naum = 1;
                }
            }

            if(number1.Length == number2.Length)
            {
                if (naum == 1)
                {
                    result[result.Length - 1] = 1;
                }
            }
            
            //Add remaining numbers
            if (n == longerNumber)
            {
                for (int i = shorterNumber; i < longerNumber; i++)
                {
                    if (number1[i] + naum == 10)
                    {
                        result[i] = 0;
                        naum = 1;
                    }
                    else
                    {
                        result[i] = number1[i] + naum;
                        naum = 0;
                    }
                }
            }
            else if (m == longerNumber)
            {
                for (int i = shorterNumber - 1; i < longerNumber; i++)
                {
                    if (number2[i] + naum == 10)
                    {
                        result[i] = number1[i];
                        naum = 1;
                    }
                    else
                    {
                        result[i] = number2[i] + naum;
                        naum = 0;
                    }                   
                }
            }
            else
            {
                if (naum == 1)
                {
                    result[result.Length - 1] = 1;
                }
            }

            //Convert int[] to string
            string output = "";
            foreach(int x in result)
            {
                output += x;
            }

            //return revirsed string
            return new ArbitraryLong(Reverse(output).TrimStart('0'));
        }

        /// <summary>
        /// Function to аddition very large positive or negative numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ArbitraryLong Addition(ArbitraryLong num1, ArbitraryLong num2)
        {
            if(num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //+//Addition
                return AdditionAbs(num1, num2);
            }
            else if(num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1,num2) == -1)
            {
                //+//Addition
                return AdditionAbs(num2, num1);
            }
            else if(num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //+//Subtraction
                return SubtractAbs(num1, num2);               
            }
            else if(num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1,num2) == -1)
            {
                //-//Subtraction
                ArbitraryLong result = SubtractAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }
            else if(num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //-//Subtraction
                ArbitraryLong result = SubtractAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if(num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //+//addition
                ArbitraryLong result = AdditionAbs(num2, num1);
                result.mark = Mark.Plus;
                return result;
            }
            else if(num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //-//Addition
                ArbitraryLong result = AdditionAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if(num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
            {
                //-//Addition
                ArbitraryLong result = AdditionAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }

            return AdditionAbs(num1, num2);
        }

        private static ArbitraryLong SubtractAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            int n = num1._number.Length;
            int m = num2._number.Length;
            int[] number1 = ArbitraryLongToIntArray(num1);
            int[] number2 = ArbitraryLongToIntArray(num2);

            //Begin Addition
            int shorterNumber = Math.Min(m, n);
            int longerNumber = Math.Max(m, n);
            int naum = 0;

            int[] result = new int[longerNumber + 1];

            //Add matching numbers
            for (int i = 0; i < shorterNumber; i++)
            {
                if (number1[i] > number2[i])
                {
                    result[i] = number1[i] - number2[i] + naum;
                    naum = 0;
                }
                else if (number1[i] < number2[i])
                {
                    result[i] = (number1[i] + 10) - number2[i] + naum;                  
                    naum = -1;
                } 
                else
                {
                    if(naum == -1)
                    {
                        result[i] = (number1[i] + 10) - number2[i] + naum;
                    }
                    else
                    {
                        result[i] = 0;
                    }                 
                }
            }

            if (n == longerNumber)
            {
                for (int i = shorterNumber; i < longerNumber; i++)
                {
                    if(number1[i] == 0)
                    {
                        result[i] = 0 + naum;
                    }
                    else
                    {
                        result[i] = number1[i] + naum;
                        naum = 0;
                    }
                }
            }
            else
            {
                for (int i = shorterNumber - 1; i < longerNumber; i++)
                {
                    if (number1[i] == 0)
                    {
                        result[i] = 0 + naum;
                    }
                    else
                    {
                        result[i] = number1[i] + naum;
                        naum = 0;
                    }
                }
            }

            //Convert int[] to string
            string output = "";
            foreach (int x in result)
            {
                output += x;
            }

            //return revirsed string
            return new ArbitraryLong(TrimLeadingZeros(Reverse(output)));
        }

        private static string TrimLeadingZeros(string input)
        {
            string output = input;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '0')
                {
                    return input.Substring(i);
                }
                else if (i + 1 > input.Length)
                {
                    return "0";
                }
            }

            return "0";
        }

        /// <summary>
        /// Function to subtraction very large positive or negative numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ArbitraryLong Subtraction(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //+//Subtraction
                return SubtractAbs(num1, num2);
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //-//Subtraction
                ArbitraryLong result = SubtractAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                ///-///addition
                ArbitraryLong result = AdditionAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //-//addition
                ArbitraryLong result = AdditionAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //+//addition
                ArbitraryLong result = AdditionAbs(num1, num2);
                result.mark = Mark.Plus;
                return result;
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
            {
                //+//addition
                ArbitraryLong result = AdditionAbs(num2, num1);
                result.mark = Mark.Plus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //-//Subtraction
                ArbitraryLong result = SubtractAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
            {
                //+//Subtraction
                ArbitraryLong result = SubtractAbs(num2, num1);
                result.mark = Mark.Plus;
                return result;
            }

            return SubtractAbs(num1, num2);
        }

        private static ArbitraryLong MultiplyWithSingleDigit(string num1, char num2)
        {
            string result = "";

            if (num1 == "0" || num2 == '0')
            {
                return new ArbitraryLong("0");
            }

            int naum = 0;
            int digit2 = Convert.ToInt32(num2.ToString());

            for (int i = num1.Length - 1; i >= 0 ; i--)
            {
                int digit1 = Convert.ToInt32(num1[i].ToString());
                result += (digit1 * digit2 + naum) % 10;
                naum = (digit1 * digit2 + naum) / 10;
            }

            result = Reverse(result);

            if (naum > 0)
            {
                result = naum + result;
            }

            return new ArbitraryLong(result);
        }

        private static ArbitraryLong MultiplicationAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            ArbitraryLong result = new ArbitraryLong("0");

            for (int i = num2._number.Length - 1; i >= 0; i--)
            {
                ArbitraryLong singleMultiplication = MultiplyWithSingleDigit(num1._number, num2._number[i]);

                //add zeros at end
                for (int j = 0; j < (num2._number.Length - 1) - i; j++)
                {
                    singleMultiplication._number += "0";
                }

                result = ArbitraryLong.AdditionAbs(singleMultiplication , result);
            }

            return result;
        }

        /// <summary>
        /// Function to multiplication very large positive or negative numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ArbitraryLong Multiplication(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //+//Multiplication
                return MultiplicationAbs(num1, num2);
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //+//Multiplication
                return MultiplicationAbs(num2, num1);
            }
            else if(num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //-//Multiplication
                ArbitraryLong result = MultiplicationAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //-//Multiplication
                ArbitraryLong result = MultiplicationAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //-//Multiplication
                ArbitraryLong result = MultiplicationAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
            {
                //-//Multiplication
                ArbitraryLong result = MultiplicationAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //+//Multiplication
                return MultiplicationAbs(num1, num2);
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
            {
                //+//Multiplication
                return MultiplicationAbs(num2, num1);
            }

            return MultiplicationAbs(num1, num2);
        }

        private static int DividePart(ArbitraryLong num1, ArbitraryLong num2, ref ArbitraryLong remainder)
        {
            if (num2._number == "0")
            {
                throw new DivideByZeroException();
            }

            int result = 0;

            while (num1._number != "0" && num1.mark != Mark.Minus && CompareAbsDivision(num1, num2) == 1)
            {
                num1 = ArbitraryLong.Subtraction(num1, num2);
                if (num1.mark == Mark.Plus)
                    result++;                  
            }

            remainder = new ArbitraryLong(num1._number);

            return result;
        }

        private static ArbitraryLong DivisionAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num2._number == "0")
            {
                throw new DivideByZeroException();
            }

            num1.mark = Mark.Plus;
            num2.mark = Mark.Plus;

            string result = "";

            int n = num1._number.Length;
            int m = num2._number.Length;

            ArbitraryLong remainder = new ArbitraryLong("0");

            result += DividePart(new ArbitraryLong(num1._number.Substring(0, m)), num2, ref remainder);

            for (int i = m; i < n; i++)
            {
                ArbitraryLong newRemainder = new ArbitraryLong(TrimLeadingZeros(remainder._number + num1._number[i]));
                result += DividePart(newRemainder, num2, ref remainder);
            }

            return new ArbitraryLong(ArbitraryLong.TrimLeadingZeros(result));
        }

        /// <summary>
        /// Function to division very large positive or negative numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static ArbitraryLong Division(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num2._number == "0")
            {
                throw new DivideByZeroException();
            }

            if (CompareAbs(num1, num2) < 1)
            {
                return new ArbitraryLong("0");
            }

            if (num1.mark == Mark.Plus && num2.mark == Mark.Plus ||
                num1.mark == Mark.Minus && num2.mark == Mark.Minus)
            {
                return DivisionAbs(num1, num2);
            }
            else
            {
                ArbitraryLong result = DivisionAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}

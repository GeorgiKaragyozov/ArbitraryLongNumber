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
        List<byte> number = new List<byte>();

        Mark mark = Mark.Plus;

        Regex regex = new Regex("^[0-9]+$");

        public ArbitraryLong(int number)
        {
            if (number < 0)
            {
                this.mark = Mark.Minus;
                number = Math.Abs(number);
            }

            while (number > 0)
            {
                this.number.Add((byte)(number % 10));
                number /= 10;
            }
        }

        private static List<byte> StringToBytes(string str)
        {        
            List<byte> bytes = new List<byte>();

            if (str[0] == '-')
            {
                str = str.Substring(1);
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                bytes.Add((byte)(str[i] - 48));
            }

            return bytes;
        }

        public static ArbitraryLong Parse(string number)
        {
            ArbitraryLong arbitraryLong = new ArbitraryLong(StringToBytes(number));

            if (number.Length > 0 && number[0] == '-')
            {
                arbitraryLong.mark = Mark.Minus;
            }

            return arbitraryLong;
        }

        public ArbitraryLong(string number)
        {
            if (number == "")
            {
                number = "0";
            }

            if (!(regex.IsMatch(number) ||
                regex.IsMatch(number.Substring(1)) && ((number[0] == '-') || (number[0] == '+'))))
            {
                throw new Exception("Please enter numbers only .");
            }

            if (number == "")
            {
                this.number.Add(0);
            }
            else
            {
                if (number[0] == '-')
                {
                    this.mark = Mark.Minus;                   
                    this.number = ArbitraryLong.StringToBytes(number.Substring(1));
                }
                else
                {
                    this.number = ArbitraryLong.StringToBytes(number);
                }
            }
        }

        public ArbitraryLong(List<byte> number)
        {
            if (number == null)
            {
                this.number.Add(0);
            }

            foreach(byte b in number)
            {
                if (b > 9)
                {
                    throw new ArgumentOutOfRangeException("The byte list contains numbers greater than 9.");
                }
            }

            this.number = number;
        }

        public ArbitraryLong() : this("0")
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
            if (num1.number.Count > num2.number.Count)
            {
                return 1;
            }
            else if (num1.number.Count < num2.number.Count)
            {
                return -1;
            }
            else
            {
                for (int i = num1.number.Count - 1; i >= 0; i--)
                {
                    if (num1.number[i] > num2.number[i])
                    {
                        return 1;
                    }
                    else if (num1.number[i] < num2.number[i])
                    {
                        return -1;
                    }
                }

                return 1;
            }
        }

        private static int Compare(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num1.number.SequenceEqual(num2.number) && (num1.mark == num2.mark))
            {
                return 0;
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Plus)
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

        private static ArbitraryLong AdditionAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            //Convert the two numbers to array of shorts
            byte n = (byte)num1.number.Count;
            byte m = (byte)num2.number.Count;

            //Begin Addition
            byte shorterNumber = Math.Min(m, n);
            byte longerNumber = Math.Max(m, n);
            byte naum = 0;

            int[] result = new int[longerNumber + 1];

            //Add matching numbers
            for (int i = 0; i < shorterNumber; i++)
            {
                if (num1.number[i] + num2.number[i] < 10)
                {
                    result[i] = num1.number[i] + num2.number[i] + naum;
                    naum = 0;

                    if (result[i] == 10)
                    {
                        result[i] = 0;
                        naum = 1;
                    }
                }
                else
                {
                    result[i] = (num1.number[i] + num2.number[i]) % 10 + naum;
                    naum = 1;
                }
            }

            if (num1.number.Count == num2.number.Count)
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
                    if (num1.number[i] + naum == 10)
                    {
                        result[i] = 0;
                        naum = 1;
                    }
                    else
                    {
                        result[i] = num1.number[i] + naum;
                        naum = 0;
                    }
                }
            }
            else if (m == longerNumber)
            {
                for (int i = shorterNumber - 1; i < longerNumber; i++)
                {
                    if (num2.number[i] + naum == 10)
                    {
                        result[i] = num1.number[i];
                        naum = 1;
                    }
                    else
                    {
                        result[i] = num2.number[i] + naum;
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
            foreach (int x in result)
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
            if (num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //+//Addition
                return AdditionAbs(num1, num2);
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //+//Addition
                return AdditionAbs(num2, num1);
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //+//Subtraction
                return SubtractAbs(num1, num2);
            }
            else if (num1.mark == Mark.Plus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
            {
                //-//Subtraction
                ArbitraryLong result = SubtractAbs(num2, num1);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
            {
                //-//Subtraction
                ArbitraryLong result = SubtractAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == -1)
            {
                //+//addition
                ArbitraryLong result = AdditionAbs(num2, num1);
                result.mark = Mark.Plus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                //-//Addition
                ArbitraryLong result = AdditionAbs(num1, num2);
                result.mark = Mark.Minus;
                return result;
            }
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Minus && CompareAbs(num1, num2) == -1)
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
            byte n = (byte)num1.number.Count;
            byte m = (byte)num2.number.Count;

            //Begin Addition
            byte shorterNumber = Math.Min(m, n);
            byte longerNumber = Math.Max(m, n);
            int naum = 0;

            int[] result = new int[longerNumber + 1];

            //Add matching numbers
            for (int i = 0; i < shorterNumber; i++)
            {
                if (num1.number[i] > num2.number[i])
                {
                    result[i] = num1.number[i] - num2.number[i] + naum;
                    naum = 0;
                }
                else if (num1.number[i] < num2.number[i])
                {
                    result[i] = (num1.number[i] + 10) - num2.number[i] + naum;
                    naum = -1;
                }
                else
                {
                    if (naum == -1)
                    {
                        result[i] = (num1.number[i] + 10) - num2.number[i] + naum;
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
                    if (num1.number[i] == 0)
                    {
                        result[i] = 0 + naum;
                    }
                    else
                    {
                        result[i] = num1.number[i] + naum;
                        naum = 0;
                    }
                }
            }
            else
            {
                for (int i = shorterNumber - 1; i < longerNumber; i++)
                {
                    if (num1.number[i] == 0)
                    {
                        result[i] = 0 + naum;
                    }
                    else
                    {
                        result[i] = num1.number[i] + naum;
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

        private static ArbitraryLong MultiplyWithSingleDigit(List<byte> num1, byte num2)
        {
            string result = "";

            if (num1.Count == 1 && num1[0] == 0 || num2 == 0)
            {
                return new ArbitraryLong("0");
            }

            int naum = 0;

            for (int i = 0; i < num1.Count; i++)
            {
                byte digit1 = num1[i];
                result += (digit1 * num2 + naum) % 10;
                naum = (digit1 * num2 + naum) / 10;
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

            for (int i = 0; i < num2.number.Count; i++)
            {
                ArbitraryLong singleMultiplication = MultiplyWithSingleDigit(num1.number, num2.number[i]);

                //add zeros at end
                for (int j = 0; j < i; j++)
                {
                    singleMultiplication.number.Insert(0, 0);
                }

                result = ArbitraryLong.AdditionAbs(singleMultiplication, result);
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
            else if (num1.mark == Mark.Minus && num2.mark == Mark.Plus && CompareAbs(num1, num2) == 1)
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

        private static byte DividePart(ArbitraryLong num1, ArbitraryLong num2, ref ArbitraryLong remainder)
        {
            if (num2.number[0] == 0 && num2.number.Count == 1)
            {
                throw new DivideByZeroException();
            }

            byte result = 0;

            while (num1.number.ToString() != "0" && num1.mark != Mark.Minus && CompareAbs(num1, num2) == 1)
            {
                num1 = ArbitraryLong.Subtraction(num1, num2);
                if (num1.mark == Mark.Plus)
                    result++;
            }          

            remainder = new ArbitraryLong(num1.number);

            return result;
        }

        private static ArbitraryLong DivisionAbs(ArbitraryLong num1, ArbitraryLong num2)
        {
            if (num2.number.Count == 1 && num2.number[0] == 0)
            {
                throw new DivideByZeroException();
            }

            num1.mark = Mark.Plus;
            num2.mark = Mark.Plus;

            string result = "";

            int n = num1.number.Count;
            int m = num2.number.Count;

            ArbitraryLong remainder = new ArbitraryLong("0");

            result += DividePart(new ArbitraryLong(num1.number.Skip(num1.number.Count - m).Take(m).ToList()), num2, ref remainder);
            num1.number.Reverse();

            for (int i = m; i < n; i++)
            {               
                ArbitraryLong newRemainder = new ArbitraryLong(TrimLeadingZeros(remainder.ToString() + num1.number[i]));
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
            if (num2.number[0] == 0 && num2.number.Count == 1)
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
            string output = this.mark == Mark.Minus ? "-" : "";

            for (int i = number.Count - 1; i >= 0; i--)
            {
                output += number[i].ToString();
            }

            return output;
        }
    }
}

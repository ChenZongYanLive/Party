using System.Collections.Generic;

namespace NoUnitTest
{
    public class NumberConverter
    {
        private readonly Dictionary<int, string> _numberDictionary = new Dictionary<int, string>
        {
            { 3 , "Fizz" },
            { 5 , "Buzz" },
            { 7 , "Whizz" },
        };

        public NumberConverter()
        {
            
        }

        public NumberConverter(Dictionary<int, string> userDictionary)
        {
            _numberDictionary = userDictionary;
        }
        
        public string Replace(int number)
        {
            var replaceArray = new List<string>();

            foreach (var (key, value) in _numberDictionary)
            {
                if(IsDivide(number, key) || HasNumber(number, key)) replaceArray.Add(value);
            }

            return replaceArray.Count > 0 ? string.Concat(replaceArray) : number.ToString();
        }

        /// <summary>
        /// 確認數字中是否存在指定的數字
        /// </summary>
        /// <param name="number"></param>
        /// <param name="compareNumber"></param>
        /// <returns></returns>
        private static bool HasNumber(int number, int compareNumber)
        {
            return number.ToString().Contains(compareNumber.ToString());
        }

        /// <summary>
        /// 數字是否可以被指定的數字整除
        /// </summary>
        /// <param name="number">被除數</param>
        /// <param name="divisor">除數</param>
        /// <returns></returns>
        private static bool IsDivide(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
                foreach (bool val in vals)
                {
                    if (!val)
                    {
                        return true; // If false found, return true
                    }
                }
                return false; // If no false found, return false
       

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            return numbers.Where(n => n % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasNumber = true;

                if (hasUpper && hasLower && hasNumber)
                    return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.LastOrDefault();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i]?.ToUpper();
            }
        }
    }
}

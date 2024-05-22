using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
            int nextNumber = startNumber;

            do
            {
                nextNumber++;
            }
            while (nextNumber % n != 0);
           
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {

            int[] arr = numbers;
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }
            int sum = 0;

            for (int i = 1; i < arr.Length; i ++)
            {
                if (arr[i-1] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string[] arr = words;
            if (arr == null || arr.Length == 0)
            {
                return string.Empty;
            }
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                var trimmedWord = words[i].Trim();
                stringBuilder.Append(trimmedWord);
                if (trimmedWord != "")
                {
                    stringBuilder.Append(" ");
                }
            }
            string sentence = stringBuilder.ToString().Trim();

            if (sentence == "")
            {
                return sentence;
            }
          
            return sentence + ".";
           
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
                return new double[0]; // Return an empty array if there are less than four elements

            return elements.Where((x, index) => (index + 1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
                return false; // Not enough elements to form a pair

            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (set.Contains(complement))
                    return true; // Found a pair
                set.Add(num);
            }

            return false; // No pair found
        }
    }
}

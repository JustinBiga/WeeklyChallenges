﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (string w in words)
            {
                if (ignoreCase)
                {
                    if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                else
                {
                    if (w == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCounts[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1; // Return -1 if no unique letter found
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0]; // Return an empty array if the input is invalid
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }

            return sumEven - sumOdd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> listOfInt = new List<int>
            {
                str1.Length, str2.Length, str3.Length, str4.Length
            };
            return listOfInt.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> listOfNumbers = new List<int>
            {
                number1, number2, number3, number4
            };
            return listOfNumbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
           (sideLength1 + sideLength3 > sideLength2) &&
           (sideLength2 + sideLength3 > sideLength1);
            //if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            //{
            //    return false;
            //}
            //if (sideLength1 + sideLength2 <= sideLength3)
            //{
            //    return false;
            //}
            //if (sideLength2 + sideLength3 <= sideLength1)
            //{
            //    return false;
            //}
            //if (sideLength3 + sideLength1 <= sideLength2)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);  //This method should return true
                                                   //if the input string represents a valid number,
                                                   //otherwise return false.
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                    nullCount++;
            }
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
         
            var evenNumbers = numbers.Where(num => num % 2 == 0);

            return evenNumbers.Any() ? evenNumbers.Average() : 0; //shorthand way of an if-else statement.

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}

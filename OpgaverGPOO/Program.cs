using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace OpgaverGPOO
{
    public static class Opgaver
    {
            public static void Interchange(ref int x, ref int y)
            {
                Console.WriteLine("X = " + x);// x = 1
                Console.WriteLine("Y = " + y);// y = 2

                int wow = x;
                x = y;
                y = wow;

                Console.WriteLine("X = " + x);// x = 2
                Console.WriteLine("Y = " + y);// y = 1
            }
            public static void InterchangeTriple(ref int x, ref int y, ref int z)
            {
            int waw = x;
            x = z;
            z = y;
            y = waw;

            }
            public static bool IsPalindrome(string s)
            {
            throw new NotImplementedException();

            {
                char[] n = s.ToCharArray();
                Array.Reverse(n);
                return new string(n).Equals(s);
            }
        }
            public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
            {
                throw new NotImplementedException();

            int steps = 0;

            for (int i = 0; i < intergerArray.Length; i++)
            {
                steps++;  // Øg antallet af steps for hver iteration

                if (intergerArray[i] == searchFor)
                    return steps;  // Tallet er fundet, returner antallet af steps
            }

            return -1;  // Tallet blev ikke fundet
        }
            public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
            {
                throw new NotImplementedException();
            int steps = 0;
            int left = 0;
            int right = integerArray.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (integerArray[mid] == searchFor)
                {
                    steps++;
                    return steps;
                }
                else if (integerArray[mid] < searchFor)
                {
                    steps++;
                    left = mid + 1;
                }
                else
                {
                    steps++;
                    right = mid - 1;
                }
            }

            return steps;
        }
            public static int InsertSortedList(List<int> sortedList, int insert)
            {
                throw new NotImplementedException();
                int hallooo = 0;
                while (hallooo < sortedList.Count && sortedList[hallooo] < insert)
                {
                    hallooo++;
                }
                sortedList.Insert(hallooo, insert);
                return hallooo;
            }
            public static int[] ArrayOfMultiples(int num, int length)
            {
                throw new NotImplementedException();
                int[] multiples = new int[length];
                for (int i = 0; i < length; i++)
                {
                    multiples[i] = num * (i + 1);
                }
                return multiples;
            }
            public static int PowerRanger(int power, int min, int max)
            {
                throw new NotImplementedException();
                int count = 0;
                int currentValue = 1;

                while (Math.Pow(currentValue, power) <= max)
                {
                    double result = Math.Pow(currentValue, power);
                    if (result >= min && result <= max)
                    {
                        count++;
                    }
                    currentValue++;
                }

                return count;
            }
            public static long Factorial(int n)
            {
                throw new NotImplementedException();
                if (n < 0)
                {
                    throw new ArgumentException("Input must be a non-negative integer.");
                }

                if (n == 0)
                {
                    return 1;
                }

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                return result;
            }
            /*
             * Exercise 9.
             * Write a function which increments a string to create a new string.
             * If the string ends with a number, the number should be incremented by 1.
             * If the string doesn't end with a number, 1 should be added to the new string.
             * If the number has leading zeros, the amount of digits should be considered.
             * exampel: 
             * wow0849 -> wow0850
             * test99 -> test100
             */
            public static string IncrementString(string txt)
            {
                throw new NotImplementedException();
                //Write your solution here
            }
            /*
             * Exercise 10.
             * Write a method to validate a sercure password.
             *     The password must contain at least one uppercase character.
             *     The password must contain at least one lowercase character.
             *     The password must contain at least one number.
             *     The password must contain at least one special character 
             *     The password must not contain other special characters then ! @ # $ % ^ & * ( ) + = - { } [ ] : ; " ' ? < > , . _
             *     The password must be at least 8 characters in length.
             *     The password must not be 25 characters or over in length.
             */
            public static bool ValidatePassword(string password)
            {
                throw new NotImplementedException();
                //Write your solution here
            }
        }
    }

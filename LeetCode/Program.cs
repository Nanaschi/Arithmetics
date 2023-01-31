using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(RomanToInt("LVIII"));

        var shaza = "Podium";
        Console.WriteLine(shaza[5]);
        //Console.WriteLine(string.Join(" ", TwoSum(new[] {2, 7, 11, 15}, 9)));
    }


    
    public static int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>();
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);
        int sum = 0;
        int last = 0;

        /*for (int i = 0; i < s.Length; i++)
        {
            int current = map[s[i]];
            if ( current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }

            last = current; 
        }*/
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int current = map[s[i]];
            if ( current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }

            last = current;
        }
        return sum;
    }
    
    public static bool IsPalindrome(int x)
    {
        char[] forwardCharArray = x.ToString().ToCharArray();
        char[] backwardsCharArray = x.ToString().ToCharArray().Reverse().ToArray();
        return forwardCharArray.SequenceEqual(backwardsCharArray);
    }

    public static int[] TwoSum(int[] nums, int target)
    { 
        int[] array = new int[] { };
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    array = new[] {i, j};
                }
            }
        }

        return array;
    }
}
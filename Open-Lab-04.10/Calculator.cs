using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float sucet = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sucet += nums[i];
            }
            return sucet / nums.Length;


        }
    }
}

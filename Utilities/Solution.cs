namespace LeetCode_27.Utilities;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        try
        {
            int[] initialNums = { };
            int[] expectedNums = { };

            initialNums = initialNums.Concat(nums).ToArray();
            Array.Sort(initialNums);

            for (int i = 0; i < initialNums.Length; i++)
            {
                for (int j = i + 1; j < initialNums.Length; j++)
                {
                    if (initialNums[i] != val)
                    {
                        if (initialNums[i] == initialNums[j])
                        {
                            /* TO DO
                             *
                             * Modify condition to remove the first duplicate value
                             * from the array and return the rest
                             * 
                             */
                            expectedNums = expectedNums.Concat(new[] { initialNums[i] }).ToArray();
                            break;
                        }
                    }
                }
            }

            foreach (var VARIABLE in expectedNums)
            {
                Console.WriteLine(VARIABLE);
            }

            return expectedNums.Length;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}
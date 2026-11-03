int[] nums = { 4, 2, 7, 1, 8, 2, 9, 3 };
int temp = 0;
for(int i = 0; i < nums.Length; i++)
{
    for (int j = i +1; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            Console.WriteLine($"the duplicate has been found: {nums[i]}, {nums[j]}");
        }
    }
}
int[] nums = { 15, 8, 3, 42, 2, 19 };
int temp = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (temp > nums[i])
    {
        temp = nums[i];
    }
} Console.WriteLine(temp);
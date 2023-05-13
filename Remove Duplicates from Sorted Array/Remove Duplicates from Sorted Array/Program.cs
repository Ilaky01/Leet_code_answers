int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int[] nums2 = new int[nums.Length];
int temp;
int count = 0;
for (int i = 0; i < nums.Length -1; i++)
{
    if (nums[i] == nums[i+1]){
        temp = nums[i];
        nums[i+1] = nums[nums.Length - 1];
        nums2[count] = temp;
        count++;
    }
}
nums = nums2;
int k = nums.Length - count;
for (int i = 0; i < nums2.Length; i++)
{
    Console.WriteLine(nums[i]);
}
Console.WriteLine(k);
return k;
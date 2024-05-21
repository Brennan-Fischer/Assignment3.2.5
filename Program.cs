namespace Assignment3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            Console.WriteLine("Input integer you wish to search for in array to determine it's index:");
            int indexSearch = Convert.ToInt32(Console.ReadLine());
            int searchIndex = MyMethods.Search(indexSearch, myArray);
        }


    }
    public class MyMethods
    {
        public static int Search(int search, params int[] nums)
        {
            int i;
            int indexResult = -1;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == search)
                {
                    Console.Write($"The value {nums[i]} is at index {i}");
                    indexResult = i;

                    break;
                }
            }
            if (indexResult == -1)
            {
                Console.Write($"The value {nums[i]} is not in the array");
            }

            return indexResult;
        }
    }
}

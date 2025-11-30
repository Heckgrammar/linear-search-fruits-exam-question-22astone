namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static string stringSearch(string key, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return "true";
                }
            }
            return "false";
        }
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            Console.WriteLine("What fruit would you like?");
            string searchKey = Console.ReadLine();
            Console.WriteLine(stringSearch(searchKey, fruits));
        }
    }
}

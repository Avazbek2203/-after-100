namespace Revision_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string input = Console.ReadLine();
            string result = "";

            for (int i = input.Length; i > 0; i--)
            {
                if (i % 3 == 0 && i != input.Length)
                {
                    result += ",";
                }
                result += input[input.Length - i];
            }

            Console.WriteLine(result);
        }
    }
}

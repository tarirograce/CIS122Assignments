namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Needle in a Haystack");

            Calculator aCalculator = new Calculator();
            string needle = "leeto";
            string haystack = "leetcodeleeto";

            int answer = aCalculator.StrStr(haystack, needle);

            Console.WriteLine(answer);
        }
    }
}

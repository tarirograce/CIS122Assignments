namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VowelFinder finder = new VowelFinder("sharpening skills", 3);
            Console.WriteLine(finder.FirstNVowels());

            VowelFinder anotherFinder = new VowelFinder("major league", 5);
            Console.WriteLine(anotherFinder.FirstNVowels());
        }
    }
}

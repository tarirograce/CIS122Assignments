namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator sentence = new Calculator("Cat, dog, and mouse.");
            Console.WriteLine(sentence.FlipEndChars());
        }
    }
}

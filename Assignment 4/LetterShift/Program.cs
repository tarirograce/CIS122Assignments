namespace LetterShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LetterMover mover = new LetterMover("hello");
            Console.WriteLine(mover.Move());
        }
    }
}

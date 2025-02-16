//written by Tariro Grace Shumba
//2/3/2025
namespace Th_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user1;
            while (true)
            {
                // prompting user to enter a number 
                Console.Write("User 1, enter a number between 0 and 100 : ");
                user1 = Convert.ToInt32(Console.ReadLine());

                // checking if number is in the right range

                if (user1 >= 0 && user1 <= 100)
                {
                    // clearing the screen so user2 can guess
                    Console.Clear();
                    Console.WriteLine("User 2, guess the number? : ");
                    int user2;

                    while (true) // another while loop so the user can continue guessing without the screen being cleared 
                    {
                        // reads the guessed number by user 2 into the variable user 2
                        user2 = Convert.ToInt32(Console.ReadLine());

                        // if statements to determine if it is too high too low or the right guess
                        if (user2 > user1)
                        {
                            Console.WriteLine($"{user2} is too high");
                        }
                        if (user2 < user1)
                        {
                            Console.WriteLine($"{user2} is too low");
                        }
                        if (user2 == user1)
                        {
                            Console.WriteLine($"You guessed the rigt number!");
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    // this requires them to re-enter the number if it is not in the range
                    Console.WriteLine("Please enter a number between 0 and 100.");
                }
            }
        }
    }
}

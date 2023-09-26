namespace ScratchPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Please tell me your name & age!");

            Console.WriteLine("Please Enter Your Name Here");
            var userName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age Here");
            int age = int.Parse(Console.ReadLine());

            //string.StartsWith() OR []            

            if (age >= 18)
            {
                Console.WriteLine($"Well hello {userName} you are {age} years old");

                if (userName[0] == 'T')
                {
                    for (var i = 0; i < 100; i++)
                    {
                        Console.WriteLine(userName);
                    }
                }

            }
            else
            {
                Console.WriteLine($"Hello little kid.");
            }

        }
    }
}
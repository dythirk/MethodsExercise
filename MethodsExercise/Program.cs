namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Please enter a noun: ");
            string noun = Console.ReadLine(); // input

            Console.WriteLine("Please enter a verb, for example 'I like to ... ' ");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Please enter another verb: ");
            string verb2 = Console.ReadLine();


            Console.WriteLine("Please enter a location: ");
            string place = Console.ReadLine();

            Console.WriteLine("Please enter a day of the week: ");
            string day = Console.ReadLine();

            Console.WriteLine($"Every {day} we go to the park to watch the {noun} {verb1}. After that we go to the {place} to {verb2}.");


        }
    }
}

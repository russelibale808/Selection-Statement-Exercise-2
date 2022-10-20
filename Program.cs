namespace SelectionStatementExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Switching Case Exsercise

            Console.WriteLine("What is your favorite school subject");
            string myFavSchoolSub  = Console.ReadLine();

           
            switch (myFavSchoolSub)
            {
                case "math":
                    Console.WriteLine("Math can be tricky");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "social studies":
                    Console.WriteLine("Social studies has alot of history and geography");
                    break;
                case "english":
                    Console.WriteLine("Enligh is fun");
                    break;
                case "wood class":
                    Console.WriteLine("I love wood class!");
                    break;
                case "arts and crafts":
                    Console.WriteLine("I love doing arts and crafts");
                    break;
                default:
                    Console.WriteLine("I don't know what subject that is");
                    break;
            }
        }
    }
}

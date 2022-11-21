namespace ArrayListExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy, would you mind entering in some names? One at a time please.");
            Console.WriteLine(@"Type ""end"" to exit");

            var namesList = new List<string>();

            while(true)
            {
                var newName = Console.ReadLine();
               namesList.Add(newName);
                var addNamesCount = namesList.Count - 2;

                if(newName == "end")
                {
                    break;
                }
                if(namesList.Count == 1)
                {
                    Console.WriteLine(string.Format("{0} liked your post.", namesList[0]));
                } else if (namesList.Count == 2)
                {
                    Console.WriteLine(string.Format("{0} and {1} liked your post.", namesList[0], namesList[1]));
                } else if (namesList.Count == 3)
                {
                    Console.WriteLine(string.Format("{0}, {1} and one other liked your post.", namesList[0], namesList[1]));
                } else if (namesList.Count >= 4)
                {
                    Console.WriteLine(string.Format("{0}, {1} and {2} others liked your post.", namesList[0], namesList[1], addNamesCount));
                }

            }
        }
    }
}
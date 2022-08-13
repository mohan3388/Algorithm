namespace AlgorithmProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the program");
            Console.WriteLine("1.Binary Serach Program\n2.Insertion sort program");
            const string File_Path = @"F:\dotnet\algorith\Algorithm\AlgorithmProblem\AlgorithmProblem\List.txt";
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter above option to execute");
                Algorithm search = new Algorithm();
                string words = File.ReadAllText(File_Path);
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:


                        string[] arr = words.Split(',');
                        Console.WriteLine("Enter word to Search");
                        string a = Console.ReadLine();

                        int result = search.BinarySearch(arr, a);
                        if (result == -1)
                            Console.WriteLine("Element not present");
                        else
                            Console.WriteLine("Element found at " + result);
                        break;
                    case 2:
                        string[] arr2 = words.Split(',');
                        InsertionSort problem = new InsertionSort();
                        problem.Insertion(arr2);
                        problem.Display(arr2);
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}
namespace AlgorithmProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the program");
            Console.WriteLine("1.Binary Serach Program\n2.Insertion sort program\n3.Bubble Sort\n4.Merge Sort Problem\n5.Anagram Problem");
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
                    case 3:
                        int[] arr3 = { 50, 29, 98, 47, 67, 20 };
                        BubbleSort problem1 = new BubbleSort();
                        problem1.Bubble(arr3);
                        problem1.Display(arr3);
                        break;
                    case 4:
                        MergeSort merge = new MergeSort();
                        int[] arr4 = { 12, 11, 13, 5, 6, 7 };
                        Console.WriteLine("Unsorted array");
                        merge.DisplayMerge(arr4);
                        merge.Sorting(arr4, 0, arr4.Length - 1);
                        Console.WriteLine("unsorted array");
                        merge.DisplayMerge(arr4);
                        break;
                    case 5:
                        Anagram anagram = new Anagram();
                        string firstname = "earth";
                        string secondname = "hearte";
                        anagram.AnagramProblem(firstname, secondname);
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}
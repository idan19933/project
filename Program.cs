class Program()
{
    static void Main(string[] args)
    {
        menu();

        string viewMenuAndChooseOption()
        {
            Console.WriteLine("Choose one of the options below: \n" +
                "a. Input A series\n" +
                "b.Display the original series\n" +
                "c.Display in reversed order\n" +
                "d.Display the series in a sorted order\n" +
                "e. Display maximum value");
            string option = Console.ReadLine()!;
            return option;
        }
        void menu()
        {
            List<int> seriesNumbers = numberSeries();
            string option = viewMenuAndChooseOption();
            while (option != "j")
            {
                switch (option)
                {
                    case "a":
                        seriesNumbers = numberSeries();
                        break;
                    case "b":
                        showList(seriesNumbers);
                        break;
                    case "c":
                        showReversedList(seriesNumbers);
                        break;
                    case "d":
                        showSortedList(seriesNumbers);
                        break;
                    case "e":
                        showMax(seriesNumbers);
                        break;
                }
                option = viewMenuAndChooseOption();
            }
            
            
        }
        void showList(List<int> numberList)
        {
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
        }

        void showReversedList(List<int> numbers)
        {
            for(int i = numbers.Count-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        void showMax(List<int> numbers)
        {
            int max = int.MinValue;
            foreach(int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(max);
        }

        List<int> numberSeries()
        {
            Console.WriteLine("Enter a series of numbers: ");
            string numbers = Console.ReadLine()!;
            string[] numberArray = numbers.Split(" ");
            List<int> numberList = new List<int>();
            foreach (string number in numberArray)
            {
                numberList.Add(int.Parse(number));
            }
            return numberList;
        }
        void showSortedList(List<int> numbers)

        {
            List<int> reversed = numbers.OrderBy(x => x).ToList();
            foreach (int number in reversed)
            {
                Console.WriteLine(number);
            }
        }
    }
}
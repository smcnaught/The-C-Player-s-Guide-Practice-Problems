List<int> lennikNumbers = new List<int>() { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
IEnumerable<int> filteredNums = from num in lennikNumbers
                                where num % 2 == 0
                                orderby num
                                select num * 2;

List<int> listy = filteredNums.ToList();

foreach (int n in listy) Console.WriteLine(n);
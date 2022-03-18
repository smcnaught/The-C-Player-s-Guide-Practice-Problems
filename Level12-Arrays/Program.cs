Console.WriteLine("The Replicator of D'To");
int[] five = new int[5];

Console.WriteLine("Please enter five comma delimited numbers. ");
string? userNumbers = Console.ReadLine() ?? null;

if (!String.IsNullOrWhiteSpace(userNumbers)) {
  int[] userNumsArr = userNumbers.Split(',').Select(int.Parse).ToArray();

  for (int i = 0; i < five.Length; i++) {
    five[i] = userNumsArr[i];

    Console.WriteLine($"User Input: {userNumsArr[i]}, Copy: {five[i]}");
  }
}

Console.WriteLine("----------------------------");
Console.WriteLine("The Laws of Freach");
int[] allValues = new int[] { 22, 33, 10, 700, 1 };
int minValue = int.MaxValue;
int sum = 0;

foreach(int val in allValues) {
  if (val < minValue) minValue = val;
  sum += val;
}

float averageValue = (float)sum / allValues.Length;

Console.WriteLine($"The lowest value in the array is {minValue}");
Console.WriteLine($"The average value in the array is {averageValue}");
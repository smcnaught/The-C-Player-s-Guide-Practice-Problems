Random random = new Random();
RecentNumbers recentNums = new RecentNumbers { recNum1 = 0, recNum2 = 0 };
Thread threadOne = new Thread(Generate);
threadOne.Start(recentNums);

void Generate(object recent) {
  RecentNumbers recents = (RecentNumbers)recent;
  while (true) {
    int latestRandom = random.Next(0, 10);
    lock(recents) {
      recents.recNum2 = recents.recNum1;
      recents.recNum1 = latestRandom;
    }

    Console.WriteLine(latestRandom);
    Thread.Sleep(1000);
  }
}

while (true) {
  Console.ReadKey(false);
  bool isDup;
  lock(recentNums) {
    isDup = recentNums.recNum1 == recentNums.recNum2;
  }

  if (isDup) Console.WriteLine("You found a dup");
  else Console.WriteLine("No dup found");
}
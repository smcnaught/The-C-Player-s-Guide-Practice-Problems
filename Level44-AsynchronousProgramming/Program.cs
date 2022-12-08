int RandomlyRecreate(string word) {
  Random random = new Random();
  bool found = false;
  int attempts = 0;
  while(!found) {
    string newWord = "";
    for (int i = 0; i < word.Length; i++) newWord += (char)('a' + random.Next(26));
    found = word == newWord;
    attempts++;
  }

  return attempts;
}

Task<int> RandomlyRecreateAsync(string word) {
  return Task.Run(() => RandomlyRecreate(word));
}

Console.WriteLine("Please enter a short word (2-5 letters)");
string userWord = Console.ReadLine();
DateTime start = DateTime.Now;
await RandomlyRecreateAsync(userWord);
DateTime finish = DateTime.Now;
Console.WriteLine($"Time elapsed {finish - start}");
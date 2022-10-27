public static class RandomExtensions {
  public static double NextDouble(this Random random, double max) {
    return random.NextDouble() * max;
  }

  public static string NextString(this Random random, params string[] values) {
    int rand = random.Next(0, values.Length);
    return values[rand];
  }

  public static bool CoinFlip(this Random random, double percentChance = 50) {
    int rand = random.Next(1, 101);
    return rand < percentChance;
  }
}
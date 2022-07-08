
class Arrow : InventoryItem {
  private static double arrowWeight = .1;
  private static double arrowVolume = .05;

  public static string arrowName = "Arrow";
  public Arrow() : base(arrowWeight, arrowVolume, arrowName) {}

  public override string ToString()
  {
    return "Rope";
  }
}
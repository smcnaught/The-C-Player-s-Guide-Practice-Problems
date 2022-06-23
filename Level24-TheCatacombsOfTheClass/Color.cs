class Color {
  public int r;
  public int g;
  public int b;

  public static Color white = new Color(255, 255, 255);
  public static Color black = new Color(0, 0, 0);
  public static Color red = new Color(255, 0, 0);
  public static Color orange = new Color(255, 165, 0);
  public static Color yellow = new Color(255, 255, 0);
  public static Color green = new Color(0, 128, 0);
  public static Color blue = new Color(0, 0, 255);
  public static Color purple = new Color(128, 0, 128);

  public Color(int rCount, int gCount, int bCount) {
    this.r = rCount;
    this.g = gCount;
    this.b = bCount;
  }
}
class Arrow {
  public ArrowheadType arrowheadType { get; set; }
  public FletchingType fletchingType { get; set; }
  public int arrowLength { get; set; }

  public Arrow() {
    this.arrowheadType = ArrowheadType.Obsidian;
    this.fletchingType = FletchingType.Plastic;
    this.arrowLength = 10;
  }

  public Arrow(ArrowheadType arrowhead, FletchingType fletching, int length)
  {
    this.arrowheadType = arrowhead;
    this.fletchingType = fletching;
    this.arrowLength = length;
  }

  public float GetCost() {
    float total = 0;
    float lengthCost = (float)(this.arrowLength * 0.05);
    total += this.GetArrowheadCost() + this.GetFletchingCost() + lengthCost;
    return total;
  }

  public static Arrow CreateEliteArrow () {
    return new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
  }

  public static Arrow CreateBeginnerArrow() {
    return new Arrow(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
  }
  
  public static Arrow CreateMarksmanArrow() {
    return new Arrow(ArrowheadType.Steel, FletchingType.GooseFeathers, 65);
  }

  private float GetArrowheadCost() {
    switch(this.arrowheadType) {
      case ArrowheadType.Steel:
        return 10;
      case ArrowheadType.Obsidian:
        return 5;
      case ArrowheadType.Wood:
        return 3;
      default:
        return 0;
    }
  }

  private float GetFletchingCost() {
    switch(this.fletchingType) {
      case FletchingType.Plastic:
        return 10;
      case FletchingType.TurkeyFeathers:
        return 5;
      case FletchingType.GooseFeathers:
        return 3;
      default:
        return 0;
    }
  }
}

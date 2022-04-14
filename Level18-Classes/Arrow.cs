class Arrow {
  public ArrowheadType arrowheadType;
  public FletchingType fletchingType;
  public int arrowLength;

  public Arrow() {
    this.arrowheadType = ArrowheadType.Obsidian;
    this.fletchingType = FletchingType.Plastic;
    this.arrowLength = 10;
  }

  public float GetCost() {
    float total = 0;
    float lengthCost = (float)(this.arrowLength * 0.05);
    total += this.GetArrowheadCost() + this.GetFletchingCost() + lengthCost;
    return total;
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

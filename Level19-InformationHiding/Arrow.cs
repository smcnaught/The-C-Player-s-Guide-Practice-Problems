class Arrow {
  private ArrowheadType arrowheadType;
  private FletchingType fletchingType;
  private int arrowLength;

  public Arrow() {
    this.arrowheadType = ArrowheadType.Obsidian;
    this.fletchingType = FletchingType.Plastic;
    this.arrowLength = 10;
  }

  public void SetArrowhead(ArrowheadType type) => this.arrowheadType = type;
  public void SetFletching(FletchingType type) => this.fletchingType = type;
  public void SetArrowLength(int length) => this.arrowLength = length;

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

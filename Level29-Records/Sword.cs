record Sword {
  public Material material;
  public Gemstone gemstone;
  public float swordLength;
  public float crossGuardWidth;

  public Sword(Material mat, Gemstone gem, float l, float w) {
    this.material = mat;
    this.gemstone = gem;
    this.swordLength = l;
    this.crossGuardWidth = w;
  }
}
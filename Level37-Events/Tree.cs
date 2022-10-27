public class Tree {
  public bool ripe { get; set; }
  private Random random = new Random();

  public void TryGrow() {
    if (this.random.NextDouble() < 0.00000001 && !this.ripe) {
      ripe = true;
      Ripened?.Invoke();
    }
  }

  public event Action Ripened;
}
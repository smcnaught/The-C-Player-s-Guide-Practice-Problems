public class Harvester {
  private int harvestCount;
  private Tree tree;

  public Harvester(Tree tree) {
    this.tree = tree;
    this.tree.Ripened += OnTreeRipened;
  }

  private void OnTreeRipened() {
    this.harvestCount++;
    this.tree.ripe = false;
    Console.WriteLine($"The tree has been harvested {this.harvestCount} times.");
  }
}
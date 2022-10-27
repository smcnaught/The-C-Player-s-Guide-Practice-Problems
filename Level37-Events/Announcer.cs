public class Announcer {
  public Announcer(Tree tree) {
    tree.Ripened += OnTreeRipened;
  }

  private void OnTreeRipened() => Console.WriteLine("The tree is ripe.");
}
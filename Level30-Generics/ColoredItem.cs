public class ColoredItem<T> {
  public ConsoleColor color;
  public T item;

  public ColoredItem(ConsoleColor color, T item) {
    this.color = color;
    this.item = item;
  }

  public void Display() {
    Console.ForegroundColor = this.color;
    Console.WriteLine(this.item);
  }
}

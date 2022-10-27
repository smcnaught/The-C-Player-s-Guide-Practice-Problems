public class Sieve {
  private Func<int, bool> decidy;

  public Sieve(Func<int, bool> delegateFunc) {
    this.decidy = delegateFunc;
  }
  
  public bool IsGood(int number) {
    return this.decidy(number);
  }
}
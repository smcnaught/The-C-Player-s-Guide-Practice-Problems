class Card {
  public bool CardIsSymbol(CardRanks rank) {
    return rank == CardRanks.money ||
           rank == CardRanks.percent ||
           rank == CardRanks.carrot ||
           rank == CardRanks.ampersand;
  }
}
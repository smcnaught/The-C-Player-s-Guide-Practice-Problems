class Pack {
  public List<InventoryItem> allItems;
  public int maxItems { get; protected set; }
  public double maxWeight { get; protected set; }
  public double maxVolume { get; protected set; }
  private int countItemsInPack = 0;
  private double packWeight = 0;
  private double packVolume = 0;

  public Pack(int maxItems, double maxWeight, double maxVolume) {
    this.maxItems = maxItems;
    this.maxWeight = maxWeight;
    this.maxVolume = maxVolume;
    this.allItems = new List<InventoryItem>();
  }

  public bool AddItemToPack(InventoryItem item) {
    if ((this.packWeight + item.weight < this.maxWeight) && 
        (this.packVolume + item.volume < this.maxVolume) &&
        (this.countItemsInPack + 1 <= this.maxItems))
    {
      this.packWeight += item.weight;
      this.packVolume += item.volume;
      this.countItemsInPack++;
      this.allItems.Add(item);
      return true;
    }
    else return false;
  }

  public int GetNumberOfItemsInPack() {
    return this.countItemsInPack;
  }

  public double GetPackWeight() {
    return this.packWeight;
  }

  public double GetPackVolume() {
    return this.packVolume;
  }  
}
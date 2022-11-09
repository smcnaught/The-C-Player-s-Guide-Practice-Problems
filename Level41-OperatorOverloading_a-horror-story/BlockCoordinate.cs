public record BlockCoordinate (int Row, int Column) {
  public static BlockCoordinate operator +(BlockCoordinate coord, BlockOffset offset) {
    return new BlockCoordinate(coord.Row + offset.RowOffset, coord.Column + offset.ColumnOffset);
  }

  public static BlockCoordinate operator +(BlockCoordinate coord, Direction dir) {
    BlockOffset goDir = dir switch {
      Direction.North => new BlockOffset(-1, 0),
      Direction.East  => new BlockOffset(0, +1),
      Direction.South => new BlockOffset(+1, 0),
      Direction.West  => new BlockOffset(0, -1)
    };
    return coord + goDir;
  }

  public int this[int number] {
    get
    {
      if (number == 0) return this.Row;
      else return this.Column;
    }
  }
}
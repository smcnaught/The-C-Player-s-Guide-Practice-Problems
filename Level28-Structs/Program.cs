Coordinate coordinate = new Coordinate(2, 1);

bool IsAdjacentCoordinate(Coordinate coord1, Coordinate coord2) {
  bool adjRow = coord1.row == (coord2.row - 1) || coord1.row == (coord2.row + 1);
  bool adjColumn = coord1.column == (coord2.column - 1) || coord1.column == (coord2.column + 1);

  return adjRow || adjColumn;
}

Coordinate coord1 = new Coordinate(1, 1);
Coordinate coord2 = new Coordinate(2, 1);
bool isAdj = IsAdjacentCoordinate(coord1, coord2);
Console.WriteLine("Coordinate 1 & 2 are " + ((isAdj) ? "adjacent" : "not adjacent"));

Coordinate coord3 = new Coordinate(1, 1);
Coordinate coord4 = new Coordinate(5, 6);
bool isAdj2 = IsAdjacentCoordinate(coord3, coord4);
Console.WriteLine("Coordinate 3 & 4 are " + ((isAdj2) ? "adjacent" : "not adjacent"));
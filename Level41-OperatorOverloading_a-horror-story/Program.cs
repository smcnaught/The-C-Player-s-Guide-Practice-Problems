BlockCoordinate coordinate = new BlockCoordinate(2, 5);
BlockOffset offset = new BlockOffset(1, 1);
Direction direction = Direction.North;

BlockCoordinate expectedResultOfOperator1 = new BlockCoordinate(3, 6);
BlockCoordinate actualResultOfOperator1 = coordinate + offset;
bool gotExpectedValueOp1 = expectedResultOfOperator1.Row == actualResultOfOperator1.Row &&
                           expectedResultOfOperator1.Column == actualResultOfOperator1.Column;

Console.WriteLine($"Operator 1 works as expected? : {gotExpectedValueOp1}");


BlockCoordinate expectedResultOfOperator2 = new BlockCoordinate(1, 5);
BlockCoordinate actualResultOfOperator2 = coordinate + direction;
bool gotExpectedValueOp2 = expectedResultOfOperator2.Row == actualResultOfOperator2.Row &&
                           expectedResultOfOperator2.Column == actualResultOfOperator2.Column;

Console.WriteLine($"Operator 2 works as expected? : {gotExpectedValueOp2}");


int coordRowValue = coordinate[0];
int coordColumnValue = coordinate[1];
Console.WriteLine($"Indexer works as expected? {coordRowValue == coordinate.Row && coordColumnValue == coordinate.Column}");
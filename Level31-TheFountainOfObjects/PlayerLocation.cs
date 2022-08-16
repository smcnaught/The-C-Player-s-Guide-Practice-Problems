public class PlayerLocation {
  public int column;
  public int row;

  public PlayerLocation(int _col, int _row) {
    this.column = _col;
    this.row = _row;
  }

  public string GetPlayerLocation() {
    return $"You are in room at (Row={this.row}, Column={this.column})";
  }

  public bool PlayerAtExit(Room exit) {
    return this.column == exit.column && this.row == exit.row;
  }

  public bool PlayerAtFountain(Room fountain) {
    return this.column == fountain.column && this.row == fountain.row;
  }

  public string SenseTheRoom(Room entrance, Room fountain, bool fountainOn) {
    if (this.PlayerAtExit(entrance)) {
      if (fountainOn) return "The Fountain of Objects has been reactivated, and you have escaped with your life!";
      else return "You see light coming from the cavern entrance";
    }
    else if (PlayerAtFountain(fountain)) {
      if (fountainOn) return "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
      else return "You hear water dripping in this room. The Fountain of Objects is here!";
    }
    else return "";
  }

  public void MoveNorth() {
    this.row--;
  }

  public void MoveSouth() {
    this.row++;
  }

  public void MoveEast() {
    this.column++;
  }

  public void MoveWest() {
    this.column--;
  }
}
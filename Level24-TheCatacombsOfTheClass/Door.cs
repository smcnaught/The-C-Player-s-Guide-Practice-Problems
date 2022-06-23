class Door {
  public int passcode;
  public DoorState state;

  public Door(int code) {
    this.passcode = code;
    this.state = DoorState.open;
  }

  public bool ChangeDoorState(DoorState newState, int code) {
    const bool success = true;
    if (state == DoorState.open && newState == DoorState.closed ||
        state == DoorState.closed && newState == DoorState.open ||
        state == DoorState.closed && newState == DoorState.locked ||
        (state == DoorState.locked && newState == DoorState.closed && code == this.passcode)    
    ) {
      this.state = newState;
      return success;
    }
    return !success;
  }

  public void ChangePasscode(int oldCode, int newCode) {
    if (oldCode == this.passcode) this.passcode = newCode;
  }
}
class PasswordValidator {
  public bool PasswordIsValid(string password) {
    const bool isValid = true;
    if (password.Length < 6 || password.Length > 13) return !isValid;

    bool hasUpper = false;
    bool hasLower = false;
    bool hasNumber = false;

    foreach (char p in password) {
      if (p.ToString() == "T" || p.ToString() == "&") return !isValid;
      else if (char.IsNumber(p)) hasNumber = true;
      else if (char.IsLower(p)) hasLower = true;
      else if (char.IsUpper(p)) hasUpper = true;
    }

    if (hasUpper && hasLower && hasNumber) return isValid;
    else return !isValid;
  }
}
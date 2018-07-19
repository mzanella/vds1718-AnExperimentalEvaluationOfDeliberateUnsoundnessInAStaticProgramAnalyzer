  void M() {
      Main(null);
  }
  
  public static void Main(string[] args) {
      assert args != null;
      assert args.Length == 0 || args[0] != null;
  }
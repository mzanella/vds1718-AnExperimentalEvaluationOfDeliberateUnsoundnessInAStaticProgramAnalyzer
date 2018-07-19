  void M() {
      Main(null);
  }
  
  public static void Main(string[] args) {
     (@*\hc{assumed args != null \&\& forall arg in args | arg != null;} @*)
      assert args != null;
      assert args.Length == 0 || args [0] != null;
  }
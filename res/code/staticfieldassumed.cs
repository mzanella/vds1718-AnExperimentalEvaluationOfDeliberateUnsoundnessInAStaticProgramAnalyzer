  static int[] a;
  
  void M() {
     (@*\hc{assumed a != null;} @*)
      assert a != null;
  }
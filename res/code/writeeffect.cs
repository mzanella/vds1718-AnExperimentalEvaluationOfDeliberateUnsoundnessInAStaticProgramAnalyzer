  class C {
    int [] a ;
    void M() {
      var b = new int [1];
      a = b;
      N();
      assert b[0] == 0;
    }

    void N () {
      if (a!=null && 0<a.Length ) {a[0] = 1;}
    }
  }
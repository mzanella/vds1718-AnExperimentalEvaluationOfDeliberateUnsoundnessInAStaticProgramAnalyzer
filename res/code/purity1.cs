  class C {
      void M() {
          var r = Random();
          assert r == Random();
      }
  
      [Pure]
      int Random() {
          return (new object()).GetHashCode();
      }
  }
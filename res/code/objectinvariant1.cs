  class C {
      bool b;
      invariant !b; /*code contract invariant*/
      void M() {
          b = true;
          N();
          assert !b;
      }
      void N() {
          assert !b;
      }
  }
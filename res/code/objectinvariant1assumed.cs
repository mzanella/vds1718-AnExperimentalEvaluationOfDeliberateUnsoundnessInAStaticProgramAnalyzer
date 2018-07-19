  class C {
      bool b;
      invariant !b; /*code contract invariant*/
      void M() {
         (@*\hc{assumed invariant(this, typeof(C))} @*)
          b = true;
          N();
          assert !b;
      }
      void N() {
         (@*\hc{assumed invariant(this, typeof(C))} @*)
          assert !b;
      }
  }
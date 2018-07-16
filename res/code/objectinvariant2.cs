  class Super {
      bool b;
  
      void N() {b=true;}
  }
  
  class Sub : Super {
      invariant !b;
      Sub() {b=false;}
      void M() {
          N();
          assert !b;
      }
  }
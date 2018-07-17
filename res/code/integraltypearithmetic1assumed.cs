  int a = ... ;
 (@*\hc{assumed (long)(a + 1) == (long)a + (long)1;} @*)
  a = a + 1;
  assert int.MinValue < a;
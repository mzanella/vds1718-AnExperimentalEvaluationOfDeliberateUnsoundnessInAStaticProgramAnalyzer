/* other code */

  void HeapExample(bool b, A a, P p) {
    p.b = a.b;

    if (b)
      a.b.x = 12;
    else
      p.b.x = 4;

    Contract.Assert(a.b.x >= 4)
  }

/* other code */
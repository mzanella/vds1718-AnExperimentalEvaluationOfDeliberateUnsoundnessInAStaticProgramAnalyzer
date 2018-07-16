  bool b = false ;
  try {
      if (*)
          throw new Exception();
      b = true ;
  } finally {
      assert b;
  }
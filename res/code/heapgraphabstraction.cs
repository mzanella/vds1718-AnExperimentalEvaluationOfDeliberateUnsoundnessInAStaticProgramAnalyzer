  void HGExample(bool b, A a, P p){
    p.b = a.b;
  
    if(b)
      a.b.x = 12;
    else
      p.b.x = 4;
  
  }
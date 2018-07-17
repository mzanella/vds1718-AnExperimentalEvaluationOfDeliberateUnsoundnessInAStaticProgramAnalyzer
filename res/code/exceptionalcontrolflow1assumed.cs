try {
    throw new Exception();
} catch(Exception) {
   (@*\hc{assumed false;} @*)
    assert false ;
}
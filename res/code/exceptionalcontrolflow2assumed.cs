bool b = false ;
*$noException$ = false;*
try {
    if (*)
        throw new Exception();
    b = true ;
   (@*\hc{$noException$ = true;} @*)
} finally {
   (@*\hc{assumed $noException$;} @*)
    assert b;
}
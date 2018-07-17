class Super {
    bool b;

    void N() {b=true;}
}

class Sub : Super {
    invariant !b;
    Sub() {b=false;}
    void M() {
        N();
       (@*\hc{assumed invariant(this, typeof(Sub));} @*)
        assert !b;
    }
}
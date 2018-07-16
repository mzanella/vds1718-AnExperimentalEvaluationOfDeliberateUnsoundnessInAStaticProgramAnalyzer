class C {
    bool b;
    invariant !b; /*code contract invariant*/
    void M() {
        *assumed invariant(this, typeof(C))*
        b = true;
        N();
        assert !b;
    }
    void N() {
        *assumed invariant(this, typeof(C))*
        assert !b;
    }
}
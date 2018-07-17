class C {
    void M() {
        var r = Random();
       (@*\hc{assumed r == Random();} @*)
        assert r == Random();
       (@*\hc{assumed r == Random();} @*)
    }

    [Pure]
    int Random() {
        return (new object()).GetHashCode();
    }
}
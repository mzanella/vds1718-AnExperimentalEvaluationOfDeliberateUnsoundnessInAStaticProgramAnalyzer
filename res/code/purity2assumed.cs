class D {
    int[] a;

    void N() {
        requires a != null && 0 < a.Length;
        var v = First();
        *assumed v == First();*
        a[0] = v + 1;
        *assumed v == First();*
        assert v == First();
        *assumed v == First();*
    }

    [Pure]
    int First() {
        requires a != null && 0 < a.Length ;
        return a[0];
    }
}
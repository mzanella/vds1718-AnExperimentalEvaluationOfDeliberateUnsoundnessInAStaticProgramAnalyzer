class C{
    void M() {
        var r = Random();
        *assumed r == Random();*
        assert r == Random();
        *assumed r == Random();*
    }

    [Pure]
    int Random() {
        return (new object()).GetHashCode();
    }
}
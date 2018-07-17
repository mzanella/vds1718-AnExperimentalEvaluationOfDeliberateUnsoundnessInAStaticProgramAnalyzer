int a = int.MaxValue;
(@*\hc{assumed a == (short)a;} @*)
short b = (short)a;
assert (int)b == int.MaxValue;
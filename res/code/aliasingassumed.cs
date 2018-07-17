void M(int[] a, int[] b){
  requires a!=null && b!=null;
  requires 0<a.Length && 0<b.Length;
 (@*\hc{assumed a==null||!object.ReferenceEquals(a,b);} @*)
  a[0] = 0;
 (@*\hc{assumed b==null||!object.ReferenceEquals(b,a);} @*)
  b[0] = 1;
  assert a[0] == 0;
}
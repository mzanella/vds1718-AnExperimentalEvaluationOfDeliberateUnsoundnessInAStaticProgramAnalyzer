void M(int[] a, int[] b){
  requires a!=null && b!=null;
  requires 0<a.Length && 0<b.Length;
  a[0] = 0;
  b[0] = 1;
  assert a[0] == 0;
}
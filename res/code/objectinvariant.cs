public class MyStack<T> where T : class {

  /* other code */

  [ContractInvariantMethod]
  void ObjectInvariant() {
    Contract.Invariant(arr != null);
    Contract.Invariant(nextfree >= 0);
    Contract.Invariant(nextfree <= arr.Length);
    Contract.Invariant(Contract.forAll(
      0, nextfree, i => arr[i] != null));
  }

  /* other code */
}
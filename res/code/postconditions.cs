public class MyStack<T> where T : class {

  /* other code */

  public T Pop() {
    Contract.Requires(!this.isEmpty());
    Contract.Ensures(Contract.Result<T>() != null);

    return this.arr[--nextfree];
  }

  /* other code */
}
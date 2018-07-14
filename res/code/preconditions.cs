public class MyStack<T> where T : class {
  private T[] arr;
  private int nextfree;

  /* other code */

  public MyStack(int len) {
    Contract.Requires(len >= 0);

    this.arr = new T[len];
    this.nextfree = 0;
  }

  /* other code */
}
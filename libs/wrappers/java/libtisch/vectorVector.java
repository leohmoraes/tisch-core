/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class vectorVector {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public vectorVector(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(vectorVector obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_vectorVector(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public vectorVector() {
    this(libtischJNI.new_vectorVector__SWIG_0(), true);
  }

  public vectorVector(long n) {
    this(libtischJNI.new_vectorVector__SWIG_1(n), true);
  }

  public long size() {
    return libtischJNI.vectorVector_size(swigCPtr, this);
  }

  public long capacity() {
    return libtischJNI.vectorVector_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    libtischJNI.vectorVector_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return libtischJNI.vectorVector_isEmpty(swigCPtr, this);
  }

  public void clear() {
    libtischJNI.vectorVector_clear(swigCPtr, this);
  }

  public void add(Vector x) {
    libtischJNI.vectorVector_add(swigCPtr, this, Vector.getCPtr(x), x);
  }

  public Vector get(int i) {
    return new Vector(libtischJNI.vectorVector_get(swigCPtr, this, i), false);
  }

  public void set(int i, Vector val) {
    libtischJNI.vectorVector_set(swigCPtr, this, i, Vector.getCPtr(val), val);
  }

}

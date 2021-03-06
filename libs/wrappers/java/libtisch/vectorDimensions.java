/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class vectorDimensions {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected vectorDimensions(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(vectorDimensions obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_vectorDimensions(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public vectorDimensions() {
    this(libtischJNI.new_vectorDimensions__SWIG_0(), true);
  }

  public vectorDimensions(long n) {
    this(libtischJNI.new_vectorDimensions__SWIG_1(n), true);
  }

  public long size() {
    return libtischJNI.vectorDimensions_size(swigCPtr, this);
  }

  public long capacity() {
    return libtischJNI.vectorDimensions_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    libtischJNI.vectorDimensions_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return libtischJNI.vectorDimensions_isEmpty(swigCPtr, this);
  }

  public void clear() {
    libtischJNI.vectorDimensions_clear(swigCPtr, this);
  }

  public void add(Dimensions x) {
    libtischJNI.vectorDimensions_add(swigCPtr, this, Dimensions.getCPtr(x), x);
  }

  public Dimensions get(int i) {
    return new Dimensions(libtischJNI.vectorDimensions_get(swigCPtr, this, i), false);
  }

  public void set(int i, Dimensions val) {
    libtischJNI.vectorDimensions_set(swigCPtr, this, i, Dimensions.getCPtr(val), val);
  }

}

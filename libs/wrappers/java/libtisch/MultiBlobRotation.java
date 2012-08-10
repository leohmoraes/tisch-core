/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class MultiBlobRotation extends Rotation {
  private long swigCPtr;

  public MultiBlobRotation(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.MultiBlobRotation_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(MultiBlobRotation obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_MultiBlobRotation(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MultiBlobRotation(long tf) {
    this(libtischJNI.new_MultiBlobRotation__SWIG_0(tf), true);
  }

  public MultiBlobRotation() {
    this(libtischJNI.new_MultiBlobRotation__SWIG_1(), true);
  }

  public FeatureBase clone() {
    long cPtr = libtischJNI.MultiBlobRotation_clone(swigCPtr, this);
    return (cPtr == 0) ? null : new MultiBlobRotation(cPtr, false);
  }

  public void load(InputState state) {
    libtischJNI.MultiBlobRotation_load(swigCPtr, this, InputState.getCPtr(state), state);
  }

  public String name() {
    return libtischJNI.MultiBlobRotation_name(swigCPtr, this);
  }

  public static MultiBlobRotation dynamic_cast(FeatureBase base) {
    long cPtr = libtischJNI.MultiBlobRotation_dynamic_cast(FeatureBase.getCPtr(base), base);
    return (cPtr == 0) ? null : new MultiBlobRotation(cPtr, false);
  }

}

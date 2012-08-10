/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class FeatureDouble extends FeatureBase {
  private long swigCPtr;

  public FeatureDouble(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.FeatureDouble_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(FeatureDouble obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_FeatureDouble(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public double result() {
    return libtischJNI.FeatureDouble_result(swigCPtr, this);
  }

  public void bounds(vectorDouble _bounds) {
    libtischJNI.FeatureDouble_bounds(swigCPtr, this, vectorDouble.getCPtr(_bounds), _bounds);
  }

  public int next() {
    return libtischJNI.FeatureDouble_next(swigCPtr, this);
  }

  public void load(InputState state) {
    libtischJNI.FeatureDouble_load(swigCPtr, this, InputState.getCPtr(state), state);
  }

  public String name() {
    return libtischJNI.FeatureDouble_name(swigCPtr, this);
  }

  public void serialize(SWIGTYPE_p_std__ostream s) {
    libtischJNI.FeatureDouble_serialize(swigCPtr, this, SWIGTYPE_p_std__ostream.getCPtr(s));
  }

  public void unserialize(SWIGTYPE_p_std__istream s) {
    libtischJNI.FeatureDouble_unserialize(swigCPtr, this, SWIGTYPE_p_std__istream.getCPtr(s));
  }

  public static FeatureDouble dynamic_cast(FeatureBase base) {
    long cPtr = libtischJNI.FeatureDouble_dynamic_cast(FeatureBase.getCPtr(base), base);
    return (cPtr == 0) ? null : new FeatureDouble(cPtr, false);
  }

}

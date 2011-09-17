/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class BlobPos extends FeatureVector {
  private long swigCPtr;

  protected BlobPos(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.SWIGBlobPosUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BlobPos obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_BlobPos(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public BlobPos(int tf) {
    this(libtischJNI.new_BlobPos__SWIG_0(tf), true);
  }

  public BlobPos() {
    this(libtischJNI.new_BlobPos__SWIG_1(), true);
  }

  public FeatureBase clone() {
    long cPtr = libtischJNI.BlobPos_clone(swigCPtr, this);
    return (cPtr == 0) ? null : new BlobPos(cPtr, false);
  }

  public void load(InputState state) {
    libtischJNI.BlobPos_load(swigCPtr, this, InputState.getCPtr(state), state);
  }

  public int next() {
    return libtischJNI.BlobPos_next(swigCPtr, this);
  }

  public String name() {
    return libtischJNI.BlobPos_name(swigCPtr, this);
  }

  public void setIds(vectorVector value) {
    libtischJNI.BlobPos_ids_set(swigCPtr, this, vectorVector.getCPtr(value), value);
  }

  public vectorVector getIds() {
    long cPtr = libtischJNI.BlobPos_ids_get(swigCPtr, this);
    return (cPtr == 0) ? null : new vectorVector(cPtr, false);
  }

  public void setCur(SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator value) {
    libtischJNI.BlobPos_cur_set(swigCPtr, this, SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator.getCPtr(value));
  }

  public SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator getCur() {
    long cPtr = libtischJNI.BlobPos_cur_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator(cPtr, false);
  }

  public static BlobPos dynamic_cast(FeatureBase base) {
    long cPtr = libtischJNI.BlobPos_dynamic_cast(FeatureBase.getCPtr(base), base);
    return (cPtr == 0) ? null : new BlobPos(cPtr, false);
  }

}

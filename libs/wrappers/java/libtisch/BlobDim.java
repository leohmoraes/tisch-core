/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class BlobDim extends FeatureDimensions {
  private long swigCPtr;

  protected BlobDim(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.SWIGBlobDimUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BlobDim obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_BlobDim(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public BlobDim(int tf) {
    this(libtischJNI.new_BlobDim__SWIG_0(tf), true);
  }

  public BlobDim() {
    this(libtischJNI.new_BlobDim__SWIG_1(), true);
  }

  public FeatureBase clone() {
    long cPtr = libtischJNI.BlobDim_clone(swigCPtr, this);
    return (cPtr == 0) ? null : new BlobDim(cPtr, false);
  }

  public void load(InputState state) {
    libtischJNI.BlobDim_load(swigCPtr, this, InputState.getCPtr(state), state);
  }

  public int next() {
    return libtischJNI.BlobDim_next(swigCPtr, this);
  }

  public String name() {
    return libtischJNI.BlobDim_name(swigCPtr, this);
  }

  public static BlobDim dynamic_cast(FeatureBase base) {
    long cPtr = libtischJNI.BlobDim_dynamic_cast(FeatureBase.getCPtr(base), base);
    return (cPtr == 0) ? null : new BlobDim(cPtr, false);
  }

}

/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BlobPos : FeatureVector {
  private HandleRef swigCPtr;

  internal BlobPos(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.BlobPosUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BlobPos obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlobPos() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_BlobPos(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BlobPos(uint tf) : this(libtischPINVOKE.new_BlobPos__SWIG_0(tf), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobPos() : this(libtischPINVOKE.new_BlobPos__SWIG_1(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FeatureBase clone() {
    IntPtr cPtr = libtischPINVOKE.BlobPos_clone(swigCPtr);
    BlobPos ret = (cPtr == IntPtr.Zero) ? null : new BlobPos(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.BlobPos_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int next() {
    int ret = libtischPINVOKE.BlobPos_next(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string name() {
    string ret = libtischPINVOKE.BlobPos_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vectorVector ids {
    set {
      libtischPINVOKE.BlobPos_ids_set(swigCPtr, vectorVector.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.BlobPos_ids_get(swigCPtr);
      vectorVector ret = (cPtr == IntPtr.Zero) ? null : new vectorVector(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator cur {
    set {
      libtischPINVOKE.BlobPos_cur_set(swigCPtr, SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.BlobPos_cur_get(swigCPtr);
      SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT__VectorT_double_t_t__iterator(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public new static BlobPos dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.BlobPos_dynamic_cast(FeatureBase.getCPtr(arg0));
    BlobPos ret = (cPtr == IntPtr.Zero) ? null : new BlobPos(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class FeatureVector : FeatureBase {
  private HandleRef swigCPtr;

  internal FeatureVector(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.FeatureVector_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FeatureVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FeatureVector() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_FeatureVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Vector result() {
    Vector ret = new Vector(libtischPINVOKE.FeatureVector_result(swigCPtr), true);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void bounds(vectorVector _bounds) {
    libtischPINVOKE.FeatureVector_bounds(swigCPtr, vectorVector.getCPtr(_bounds));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int next() {
    int ret = libtischPINVOKE.FeatureVector_next(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.FeatureVector_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string name() {
    string ret = libtischPINVOKE.FeatureVector_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void serialize(SWIGTYPE_p_std__ostream s) {
    libtischPINVOKE.FeatureVector_serialize(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(s));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void unserialize(SWIGTYPE_p_std__istream s) {
    libtischPINVOKE.FeatureVector_unserialize(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(s));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FeatureVector dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.FeatureVector_dynamic_cast(FeatureBase.getCPtr(arg0));
    FeatureVector ret = (cPtr == IntPtr.Zero) ? null : new FeatureVector(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

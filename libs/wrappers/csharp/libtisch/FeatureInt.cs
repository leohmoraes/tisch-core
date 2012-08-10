/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class FeatureInt : FeatureBase {
  private HandleRef swigCPtr;

  internal FeatureInt(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.FeatureInt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FeatureInt obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FeatureInt() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_FeatureInt(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public int result() {
    int ret = libtischPINVOKE.FeatureInt_result(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void bounds(vectorInt _bounds) {
    libtischPINVOKE.FeatureInt_bounds(swigCPtr, vectorInt.getCPtr(_bounds));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int next() {
    int ret = libtischPINVOKE.FeatureInt_next(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.FeatureInt_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string name() {
    string ret = libtischPINVOKE.FeatureInt_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void serialize(SWIGTYPE_p_std__ostream s) {
    libtischPINVOKE.FeatureInt_serialize(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(s));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void unserialize(SWIGTYPE_p_std__istream s) {
    libtischPINVOKE.FeatureInt_unserialize(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(s));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FeatureInt dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.FeatureInt_dynamic_cast(FeatureBase.getCPtr(arg0));
    FeatureInt ret = (cPtr == IntPtr.Zero) ? null : new FeatureInt(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

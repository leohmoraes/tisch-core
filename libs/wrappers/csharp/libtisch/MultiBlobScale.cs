/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MultiBlobScale : Scale {
  private HandleRef swigCPtr;

  internal MultiBlobScale(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.MultiBlobScale_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MultiBlobScale obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MultiBlobScale() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_MultiBlobScale(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MultiBlobScale(uint tf) : this(libtischPINVOKE.new_MultiBlobScale__SWIG_0(tf), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultiBlobScale() : this(libtischPINVOKE.new_MultiBlobScale__SWIG_1(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FeatureBase clone() {
    IntPtr cPtr = libtischPINVOKE.MultiBlobScale_clone(swigCPtr);
    MultiBlobScale ret = (cPtr == IntPtr.Zero) ? null : new MultiBlobScale(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.MultiBlobScale_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string name() {
    string ret = libtischPINVOKE.MultiBlobScale_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static MultiBlobScale dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.MultiBlobScale_dynamic_cast(FeatureBase.getCPtr(arg0));
    MultiBlobScale ret = (cPtr == IntPtr.Zero) ? null : new MultiBlobScale(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

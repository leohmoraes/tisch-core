/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class dequeBasicBlob : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal dequeBasicBlob(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(dequeBasicBlob obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~dequeBasicBlob() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_dequeBasicBlob(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public dequeBasicBlob() : this(libtischPINVOKE.new_dequeBasicBlob__SWIG_0(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public dequeBasicBlob(uint size, BasicBlob value) : this(libtischPINVOKE.new_dequeBasicBlob__SWIG_1(size, BasicBlob.getCPtr(value)), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public dequeBasicBlob(uint size) : this(libtischPINVOKE.new_dequeBasicBlob__SWIG_2(size), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public dequeBasicBlob(dequeBasicBlob arg0) : this(libtischPINVOKE.new_dequeBasicBlob__SWIG_3(dequeBasicBlob.getCPtr(arg0)), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void assign(uint n, BasicBlob value) {
    libtischPINVOKE.dequeBasicBlob_assign(swigCPtr, n, BasicBlob.getCPtr(value));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(dequeBasicBlob x) {
    libtischPINVOKE.dequeBasicBlob_swap(swigCPtr, dequeBasicBlob.getCPtr(x));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint size() {
    uint ret = libtischPINVOKE.dequeBasicBlob_size(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint max_size() {
    uint ret = libtischPINVOKE.dequeBasicBlob_max_size(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resize(uint n, BasicBlob c) {
    libtischPINVOKE.dequeBasicBlob_resize__SWIG_0(swigCPtr, n, BasicBlob.getCPtr(c));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(uint n) {
    libtischPINVOKE.dequeBasicBlob_resize__SWIG_1(swigCPtr, n);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = libtischPINVOKE.dequeBasicBlob_empty(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BasicBlob front() {
    BasicBlob ret = new BasicBlob(libtischPINVOKE.dequeBasicBlob_front(swigCPtr), false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BasicBlob back() {
    BasicBlob ret = new BasicBlob(libtischPINVOKE.dequeBasicBlob_back(swigCPtr), false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void push_front(BasicBlob x) {
    libtischPINVOKE.dequeBasicBlob_push_front(swigCPtr, BasicBlob.getCPtr(x));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void push_back(BasicBlob x) {
    libtischPINVOKE.dequeBasicBlob_push_back(swigCPtr, BasicBlob.getCPtr(x));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_front() {
    libtischPINVOKE.dequeBasicBlob_pop_front(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    libtischPINVOKE.dequeBasicBlob_pop_back(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    libtischPINVOKE.dequeBasicBlob_clear(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public BasicBlob getitem(int i) {
    BasicBlob ret = new BasicBlob(libtischPINVOKE.dequeBasicBlob_getitem(swigCPtr, i), false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setitem(int i, BasicBlob x) {
    libtischPINVOKE.dequeBasicBlob_setitem(swigCPtr, i, BasicBlob.getCPtr(x));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void delitem(int i) {
    libtischPINVOKE.dequeBasicBlob_delitem(swigCPtr, i);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public dequeBasicBlob getslice(int i, int j) {
    dequeBasicBlob ret = new dequeBasicBlob(libtischPINVOKE.dequeBasicBlob_getslice(swigCPtr, i, j), true);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setslice(int i, int j, dequeBasicBlob v) {
    libtischPINVOKE.dequeBasicBlob_setslice(swigCPtr, i, j, dequeBasicBlob.getCPtr(v));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void delslice(int i, int j) {
    libtischPINVOKE.dequeBasicBlob_delslice(swigCPtr, i, j);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

}

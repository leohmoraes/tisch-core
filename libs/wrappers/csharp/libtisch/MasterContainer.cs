/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MasterContainer : Container {
  private HandleRef swigCPtr;

  internal MasterContainer(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.MasterContainerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MasterContainer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MasterContainer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_MasterContainer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MasterContainer(int w, int h, string target) : this(libtischPINVOKE.new_MasterContainer__SWIG_0(w, h, target), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public MasterContainer(int w, int h) : this(libtischPINVOKE.new_MasterContainer__SWIG_1(w, h), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public override void doUpdate(Widget target) {
    if (this.GetType() == typeof(MasterContainer)) libtischPINVOKE.MasterContainer_doUpdate__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(target)); else libtischPINVOKE.MasterContainer_doUpdateSwigExplicitMasterContainer__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(target));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void doUpdate() {
    if (this.GetType() == typeof(MasterContainer)) libtischPINVOKE.MasterContainer_doUpdate__SWIG_1(swigCPtr); else libtischPINVOKE.MasterContainer_doUpdateSwigExplicitMasterContainer__SWIG_1(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void adjust(int w, int h) {
    libtischPINVOKE.MasterContainer_adjust(swigCPtr, w, h);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void usePeak() {
    libtischPINVOKE.MasterContainer_usePeak(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public int process_gestures() {
    int ret = libtischPINVOKE.MasterContainer_process_gestures(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  protected SWIGTYPE_p_InternalMatcher matcher {
    set {
      libtischPINVOKE.MasterContainer_matcher_set(swigCPtr, SWIGTYPE_p_InternalMatcher.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.MasterContainer_matcher_get(swigCPtr);
      SWIGTYPE_p_InternalMatcher ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_InternalMatcher(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  protected MatcherTUIOInput input {
    set {
      libtischPINVOKE.MasterContainer_input_set(swigCPtr, MatcherTUIOInput.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.MasterContainer_input_get(swigCPtr);
      MatcherTUIOInput ret = (cPtr == IntPtr.Zero) ? null : new MatcherTUIOInput(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  protected SWIGTYPE_p_InputThread inthread {
    set {
      libtischPINVOKE.MasterContainer_inthread_set(swigCPtr, SWIGTYPE_p_InputThread.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.MasterContainer_inthread_get(swigCPtr);
      SWIGTYPE_p_InputThread ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_InputThread(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("outline", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMasterContainer_0(SwigDirectoroutline);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMasterContainer_1(SwigDirectorupdate__SWIG_0);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMasterContainer_2(SwigDirectorupdate__SWIG_1);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMasterContainer_3(SwigDirectordoUpdate__SWIG_0);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMasterContainer_4(SwigDirectordoUpdate__SWIG_1);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMasterContainer_5(SwigDirectorraise__SWIG_0);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMasterContainer_6(SwigDirectorraise__SWIG_1);
    if (SwigDerivedClassHasMethod("lower", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMasterContainer_7(SwigDirectorlower__SWIG_0);
    if (SwigDerivedClassHasMethod("lower", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMasterContainer_8(SwigDirectorlower__SWIG_1);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMasterContainer_9(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("action", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMasterContainer_10(SwigDirectoraction);
    if (SwigDerivedClassHasMethod("enter", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMasterContainer_11(SwigDirectorenter__SWIG_0);
    if (SwigDerivedClassHasMethod("enter", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMasterContainer_12(SwigDirectorenter__SWIG_1);
    if (SwigDerivedClassHasMethod("paint", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMasterContainer_13(SwigDirectorpaint__SWIG_0);
    if (SwigDerivedClassHasMethod("paint", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMasterContainer_14(SwigDirectorpaint__SWIG_1);
    if (SwigDerivedClassHasMethod("tap", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMasterContainer_15(SwigDirectortap);
    if (SwigDerivedClassHasMethod("release", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMasterContainer_16(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("apply", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMasterContainer_17(SwigDirectorapply);
    libtischPINVOKE.MasterContainer_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MasterContainer));
    return hasDerivedMethod;
  }

  private void SwigDirectoroutline() {
    outline();
  }

  private void SwigDirectorupdate__SWIG_0(IntPtr target) {
    update((target == IntPtr.Zero) ? null : new Widget(target, false));
  }

  private void SwigDirectorupdate__SWIG_1() {
    update();
  }

  private void SwigDirectordoUpdate__SWIG_0(IntPtr target) {
    doUpdate((target == IntPtr.Zero) ? null : new Widget(target, false));
  }

  private void SwigDirectordoUpdate__SWIG_1() {
    doUpdate();
  }

  private void SwigDirectorraise__SWIG_0(IntPtr widget) {
    raise((widget == IntPtr.Zero) ? null : new Widget(widget, false));
  }

  private void SwigDirectorraise__SWIG_1() {
    raise();
  }

  private void SwigDirectorlower__SWIG_0(IntPtr widget) {
    lower((widget == IntPtr.Zero) ? null : new Widget(widget, false));
  }

  private void SwigDirectorlower__SWIG_1() {
    lower();
  }

  private void SwigDirectordraw() {
    draw();
  }

  private void SwigDirectoraction(IntPtr gesture) {
    action((gesture == IntPtr.Zero) ? null : new Gesture(gesture, false));
  }

  private void SwigDirectorenter__SWIG_0(double z) {
    enter(z);
  }

  private void SwigDirectorenter__SWIG_1() {
    enter();
  }

  private void SwigDirectorpaint__SWIG_0(bool update_stencil) {
    paint(update_stencil);
  }

  private void SwigDirectorpaint__SWIG_1() {
    paint();
  }

  private void SwigDirectortap(IntPtr vec, int id) {
    tap(new Vector(vec, false), id);
  }

  private void SwigDirectorrelease() {
    release();
  }

  private void SwigDirectorapply(IntPtr delta) {
    apply(new Vector(delta, false));
  }

  public delegate void SwigDelegateMasterContainer_0();
  public delegate void SwigDelegateMasterContainer_1(IntPtr target);
  public delegate void SwigDelegateMasterContainer_2();
  public delegate void SwigDelegateMasterContainer_3(IntPtr target);
  public delegate void SwigDelegateMasterContainer_4();
  public delegate void SwigDelegateMasterContainer_5(IntPtr widget);
  public delegate void SwigDelegateMasterContainer_6();
  public delegate void SwigDelegateMasterContainer_7(IntPtr widget);
  public delegate void SwigDelegateMasterContainer_8();
  public delegate void SwigDelegateMasterContainer_9();
  public delegate void SwigDelegateMasterContainer_10(IntPtr gesture);
  public delegate void SwigDelegateMasterContainer_11(double z);
  public delegate void SwigDelegateMasterContainer_12();
  public delegate void SwigDelegateMasterContainer_13(bool update_stencil);
  public delegate void SwigDelegateMasterContainer_14();
  public delegate void SwigDelegateMasterContainer_15(IntPtr vec, int id);
  public delegate void SwigDelegateMasterContainer_16();
  public delegate void SwigDelegateMasterContainer_17(IntPtr delta);

  private SwigDelegateMasterContainer_0 swigDelegate0;
  private SwigDelegateMasterContainer_1 swigDelegate1;
  private SwigDelegateMasterContainer_2 swigDelegate2;
  private SwigDelegateMasterContainer_3 swigDelegate3;
  private SwigDelegateMasterContainer_4 swigDelegate4;
  private SwigDelegateMasterContainer_5 swigDelegate5;
  private SwigDelegateMasterContainer_6 swigDelegate6;
  private SwigDelegateMasterContainer_7 swigDelegate7;
  private SwigDelegateMasterContainer_8 swigDelegate8;
  private SwigDelegateMasterContainer_9 swigDelegate9;
  private SwigDelegateMasterContainer_10 swigDelegate10;
  private SwigDelegateMasterContainer_11 swigDelegate11;
  private SwigDelegateMasterContainer_12 swigDelegate12;
  private SwigDelegateMasterContainer_13 swigDelegate13;
  private SwigDelegateMasterContainer_14 swigDelegate14;
  private SwigDelegateMasterContainer_15 swigDelegate15;
  private SwigDelegateMasterContainer_16 swigDelegate16;
  private SwigDelegateMasterContainer_17 swigDelegate17;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes6 = new Type[] {  };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes8 = new Type[] {  };
  private static Type[] swigMethodTypes9 = new Type[] {  };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(Gesture) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(double) };
  private static Type[] swigMethodTypes12 = new Type[] {  };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(bool) };
  private static Type[] swigMethodTypes14 = new Type[] {  };
  private static Type[] swigMethodTypes15 = new Type[] { typeof(Vector), typeof(int) };
  private static Type[] swigMethodTypes16 = new Type[] {  };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(Vector) };
}

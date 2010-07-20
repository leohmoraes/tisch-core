/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Label : Widget {
  private HandleRef swigCPtr;

  internal Label(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.LabelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Label obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Label() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_Label(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Label(string text, int _w, int _h, int _x, int _y, double angle, int center, int snip, RGBATexture _tex) : this(libtischPINVOKE.new_Label__SWIG_0(text, _w, _h, _x, _y, angle, center, snip, libtischPINVOKE.getCPtrAddRef(_tex)), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Label(string text, int _w, int _h, int _x, int _y, double angle, int center, int snip) : this(libtischPINVOKE.new_Label__SWIG_1(text, _w, _h, _x, _y, angle, center, snip), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Label(string text, int _w, int _h, int _x, int _y, double angle, int center) : this(libtischPINVOKE.new_Label__SWIG_2(text, _w, _h, _x, _y, angle, center), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Label(string text, int _w, int _h, int _x, int _y, double angle) : this(libtischPINVOKE.new_Label__SWIG_3(text, _w, _h, _x, _y, angle), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Label(string text, int _w, int _h, int _x, int _y) : this(libtischPINVOKE.new_Label__SWIG_4(text, _w, _h, _x, _y), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Label(string text, int _w, int _h, int _x) : this(libtischPINVOKE.new_Label__SWIG_5(text, _w, _h, _x), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Label(string text, int _w, int _h) : this(libtischPINVOKE.new_Label__SWIG_6(text, _w, _h), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public override void draw() {
    if (this.GetType() == typeof(Label)) libtischPINVOKE.Label_draw(swigCPtr); else libtischPINVOKE.Label_drawSwigExplicitLabel(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void action(Gesture gesture) {
    if (this.GetType() == typeof(Label)) libtischPINVOKE.Label_action(swigCPtr, Gesture.getCPtr(gesture)); else libtischPINVOKE.Label_actionSwigExplicitLabel(swigCPtr, Gesture.getCPtr(gesture));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set(string _text) {
    libtischPINVOKE.Label_set(swigCPtr, _text);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  protected string text {
    set {
      libtischPINVOKE.Label_text_set(swigCPtr, value);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libtischPINVOKE.Label_text_get(swigCPtr);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  protected int center {
    set {
      libtischPINVOKE.Label_center_set(swigCPtr, value);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = libtischPINVOKE.Label_center_get(swigCPtr);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  protected int snip {
    set {
      libtischPINVOKE.Label_snip_set(swigCPtr, value);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = libtischPINVOKE.Label_snip_get(swigCPtr);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("outline", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateLabel_0(SwigDirectoroutline);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateLabel_1(SwigDirectorupdate__SWIG_0);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateLabel_2(SwigDirectorupdate__SWIG_1);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateLabel_3(SwigDirectordoUpdate__SWIG_0);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateLabel_4(SwigDirectordoUpdate__SWIG_1);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateLabel_5(SwigDirectordoUpdate__SWIG_2);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateLabel_6(SwigDirectorraise__SWIG_0);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateLabel_7(SwigDirectorraise__SWIG_1);
    if (SwigDerivedClassHasMethod("lower", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateLabel_8(SwigDirectorlower__SWIG_0);
    if (SwigDerivedClassHasMethod("lower", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateLabel_9(SwigDirectorlower__SWIG_1);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateLabel_10(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("action", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateLabel_11(SwigDirectoraction);
    if (SwigDerivedClassHasMethod("enter", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateLabel_12(SwigDirectorenter__SWIG_0);
    if (SwigDerivedClassHasMethod("enter", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateLabel_13(SwigDirectorenter__SWIG_1);
    if (SwigDerivedClassHasMethod("paint", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateLabel_14(SwigDirectorpaint__SWIG_0);
    if (SwigDerivedClassHasMethod("paint", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateLabel_15(SwigDirectorpaint__SWIG_1);
    libtischPINVOKE.Label_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Label));
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

  private void SwigDirectordoUpdate__SWIG_0(IntPtr target, IntPtr ost) {
    doUpdate((target == IntPtr.Zero) ? null : new Widget(target, false), (ost == IntPtr.Zero) ? null : new SWIGTYPE_p_std__ostream(ost, false));
  }

  private void SwigDirectordoUpdate__SWIG_1(IntPtr target) {
    doUpdate((target == IntPtr.Zero) ? null : new Widget(target, false));
  }

  private void SwigDirectordoUpdate__SWIG_2() {
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

  public delegate void SwigDelegateLabel_0();
  public delegate void SwigDelegateLabel_1(IntPtr target);
  public delegate void SwigDelegateLabel_2();
  public delegate void SwigDelegateLabel_3(IntPtr target, IntPtr ost);
  public delegate void SwigDelegateLabel_4(IntPtr target);
  public delegate void SwigDelegateLabel_5();
  public delegate void SwigDelegateLabel_6(IntPtr widget);
  public delegate void SwigDelegateLabel_7();
  public delegate void SwigDelegateLabel_8(IntPtr widget);
  public delegate void SwigDelegateLabel_9();
  public delegate void SwigDelegateLabel_10();
  public delegate void SwigDelegateLabel_11(IntPtr gesture);
  public delegate void SwigDelegateLabel_12(double z);
  public delegate void SwigDelegateLabel_13();
  public delegate void SwigDelegateLabel_14(bool update_stencil);
  public delegate void SwigDelegateLabel_15();

  private SwigDelegateLabel_0 swigDelegate0;
  private SwigDelegateLabel_1 swigDelegate1;
  private SwigDelegateLabel_2 swigDelegate2;
  private SwigDelegateLabel_3 swigDelegate3;
  private SwigDelegateLabel_4 swigDelegate4;
  private SwigDelegateLabel_5 swigDelegate5;
  private SwigDelegateLabel_6 swigDelegate6;
  private SwigDelegateLabel_7 swigDelegate7;
  private SwigDelegateLabel_8 swigDelegate8;
  private SwigDelegateLabel_9 swigDelegate9;
  private SwigDelegateLabel_10 swigDelegate10;
  private SwigDelegateLabel_11 swigDelegate11;
  private SwigDelegateLabel_12 swigDelegate12;
  private SwigDelegateLabel_13 swigDelegate13;
  private SwigDelegateLabel_14 swigDelegate14;
  private SwigDelegateLabel_15 swigDelegate15;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(Widget), typeof(SWIGTYPE_p_std__ostream) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes5 = new Type[] {  };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes7 = new Type[] {  };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes9 = new Type[] {  };
  private static Type[] swigMethodTypes10 = new Type[] {  };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(Gesture) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(double) };
  private static Type[] swigMethodTypes13 = new Type[] {  };
  private static Type[] swigMethodTypes14 = new Type[] { typeof(bool) };
  private static Type[] swigMethodTypes15 = new Type[] {  };
}

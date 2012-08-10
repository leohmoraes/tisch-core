/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class Window extends GLUTWindow {
  private long swigCPtr;

  public Window(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.Window_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(Window obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_Window(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    libtischJNI.Window_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    libtischJNI.Window_change_ownership(this, swigCPtr, true);
  }

  public Window(int w, int h, String title, int use_mouse) {
    this(libtischJNI.new_Window__SWIG_0(w, h, title, use_mouse), true);
    libtischJNI.Window_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Window(int w, int h, String title) {
    this(libtischJNI.new_Window__SWIG_1(w, h, title), true);
    libtischJNI.Window_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public void idle() {
    if (getClass() == Window.class) libtischJNI.Window_idle(swigCPtr, this); else libtischJNI.Window_idleSwigExplicitWindow(swigCPtr, this);
  }

  public void display() {
    if (getClass() == Window.class) libtischJNI.Window_display(swigCPtr, this); else libtischJNI.Window_displaySwigExplicitWindow(swigCPtr, this);
  }

  public void reshape(int w, int h) {
    if (getClass() == Window.class) libtischJNI.Window_reshape(swigCPtr, this, w, h); else libtischJNI.Window_reshapeSwigExplicitWindow(swigCPtr, this, w, h);
  }

  public void keyboard(int key, int x, int y) {
    if (getClass() == Window.class) libtischJNI.Window_keyboard(swigCPtr, this, key, x, y); else libtischJNI.Window_keyboardSwigExplicitWindow(swigCPtr, this, key, x, y);
  }

  public void mouse(int num, int button, int state, int x, int y) {
    if (getClass() == Window.class) libtischJNI.Window_mouse(swigCPtr, this, num, button, state, x, y); else libtischJNI.Window_mouseSwigExplicitWindow(swigCPtr, this, num, button, state, x, y);
  }

  public void motion(int num, int x, int y) {
    if (getClass() == Window.class) libtischJNI.Window_motion(swigCPtr, this, num, x, y); else libtischJNI.Window_motionSwigExplicitWindow(swigCPtr, this, num, x, y);
  }

  public void passive(int num, int x, int y) {
    if (getClass() == Window.class) libtischJNI.Window_passive(swigCPtr, this, num, x, y); else libtischJNI.Window_passiveSwigExplicitWindow(swigCPtr, this, num, x, y);
  }

  public void entry(int num, int state) {
    if (getClass() == Window.class) libtischJNI.Window_entry(swigCPtr, this, num, state); else libtischJNI.Window_entrySwigExplicitWindow(swigCPtr, this, num, state);
  }

  public void add(Widget w, int back) {
    libtischJNI.Window_add__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(w), w, back);
  }

  public void add(Widget w) {
    libtischJNI.Window_add__SWIG_1(swigCPtr, this, libtischJNI.getCPtrAddRef(w), w);
  }

  public void remove(Widget widget, int unreg) {
    libtischJNI.Window_remove__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(widget), widget, unreg);
  }

  public void remove(Widget widget) {
    libtischJNI.Window_remove__SWIG_1(swigCPtr, this, libtischJNI.getCPtrAddRef(widget), widget);
  }

  public void update(Widget target) {
    if (getClass() == Window.class) libtischJNI.Window_update__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target); else libtischJNI.Window_updateSwigExplicitWindow__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target);
  }

  public void update() {
    if (getClass() == Window.class) libtischJNI.Window_update__SWIG_1(swigCPtr, this); else libtischJNI.Window_updateSwigExplicitWindow__SWIG_1(swigCPtr, this);
  }

  public void adjust(int w, int h) {
    libtischJNI.Window_adjust(swigCPtr, this, w, h);
  }

  public void usePeak() {
    libtischJNI.Window_usePeak(swigCPtr, this);
  }

}

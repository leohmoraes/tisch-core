/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class Widget {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public Widget(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(Widget obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_Widget(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    libtischJNI.Widget_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    libtischJNI.Widget_change_ownership(this, swigCPtr, true);
  }

  public Widget(int _w, int _h, int _x, int _y, double _angle, RGBATexture _tex, long _regflags) {
    this(libtischJNI.new_Widget__SWIG_0(_w, _h, _x, _y, _angle, libtischJNI.getCPtrAddRef(_tex), _tex, _regflags), true);
    libtischJNI.Widget_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Widget(int _w, int _h, int _x, int _y, double _angle, RGBATexture _tex) {
    this(libtischJNI.new_Widget__SWIG_1(_w, _h, _x, _y, _angle, libtischJNI.getCPtrAddRef(_tex), _tex), true);
    libtischJNI.Widget_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Widget(int _w, int _h, int _x, int _y, double _angle) {
    this(libtischJNI.new_Widget__SWIG_2(_w, _h, _x, _y, _angle), true);
    libtischJNI.Widget_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Widget(int _w, int _h, int _x, int _y) {
    this(libtischJNI.new_Widget__SWIG_3(_w, _h, _x, _y), true);
    libtischJNI.Widget_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Widget(int _w, int _h, int _x) {
    this(libtischJNI.new_Widget__SWIG_4(_w, _h, _x), true);
    libtischJNI.Widget_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Widget(int _w, int _h) {
    this(libtischJNI.new_Widget__SWIG_5(_w, _h), true);
    libtischJNI.Widget_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public Vector glOutline2d(double ox, double oy, int push) {
    return new Vector(libtischJNI.Widget_glOutline2d__SWIG_0(swigCPtr, this, ox, oy, push), true);
  }

  public Vector glOutline2d(double ox, double oy) {
    return new Vector(libtischJNI.Widget_glOutline2d__SWIG_1(swigCPtr, this, ox, oy), true);
  }

  public void outline() {
    if (getClass() == Widget.class) libtischJNI.Widget_outline(swigCPtr, this); else libtischJNI.Widget_outlineSwigExplicitWidget(swigCPtr, this);
  }

  public void update(Widget target) {
    if (getClass() == Widget.class) libtischJNI.Widget_update__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target); else libtischJNI.Widget_updateSwigExplicitWidget__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target);
  }

  public void update() {
    if (getClass() == Widget.class) libtischJNI.Widget_update__SWIG_1(swigCPtr, this); else libtischJNI.Widget_updateSwigExplicitWidget__SWIG_1(swigCPtr, this);
  }

  public void doUpdate(Widget target) {
    if (getClass() == Widget.class) libtischJNI.Widget_doUpdate__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target); else libtischJNI.Widget_doUpdateSwigExplicitWidget__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target);
  }

  public void doUpdate() {
    if (getClass() == Widget.class) libtischJNI.Widget_doUpdate__SWIG_1(swigCPtr, this); else libtischJNI.Widget_doUpdateSwigExplicitWidget__SWIG_1(swigCPtr, this);
  }

  public void raise(Widget widget) {
    if (getClass() == Widget.class) libtischJNI.Widget_raise__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(widget), widget); else libtischJNI.Widget_raiseSwigExplicitWidget__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(widget), widget);
  }

  public void raise() {
    if (getClass() == Widget.class) libtischJNI.Widget_raise__SWIG_1(swigCPtr, this); else libtischJNI.Widget_raiseSwigExplicitWidget__SWIG_1(swigCPtr, this);
  }

  public void lower(Widget widget) {
    if (getClass() == Widget.class) libtischJNI.Widget_lower__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(widget), widget); else libtischJNI.Widget_lowerSwigExplicitWidget__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(widget), widget);
  }

  public void lower() {
    if (getClass() == Widget.class) libtischJNI.Widget_lower__SWIG_1(swigCPtr, this); else libtischJNI.Widget_lowerSwigExplicitWidget__SWIG_1(swigCPtr, this);
  }

  public void transform(Vector vec, int abs, int local) {
    libtischJNI.Widget_transform__SWIG_0(swigCPtr, this, Vector.getCPtr(vec), vec, abs, local);
  }

  public void transform(Vector vec, int abs) {
    libtischJNI.Widget_transform__SWIG_1(swigCPtr, this, Vector.getCPtr(vec), vec, abs);
  }

  public void transform(Vector vec) {
    libtischJNI.Widget_transform__SWIG_2(swigCPtr, this, Vector.getCPtr(vec), vec);
  }

  public void texture(RGBATexture tex) {
    libtischJNI.Widget_texture(swigCPtr, this, libtischJNI.getCPtrAddRef(tex), tex);
  }

  public void color(double r, double g, double b, double a) {
    libtischJNI.Widget_color(swigCPtr, this, r, g, b, a);
  }

  public void setangle(double _angle) {
    libtischJNI.Widget_setangle(swigCPtr, this, _angle);
  }

  public void draw() {
    if (getClass() == Widget.class) libtischJNI.Widget_draw(swigCPtr, this); else libtischJNI.Widget_drawSwigExplicitWidget(swigCPtr, this);
  }

  public void action(Gesture gesture) {
    libtischJNI.Widget_action(swigCPtr, this, Gesture.getCPtr(gesture), gesture);
  }

  public void paint_tex(RGBATexture tex) {
    libtischJNI.Widget_paint_tex__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(tex), tex);
  }

  public void paint_tex() {
    libtischJNI.Widget_paint_tex__SWIG_1(swigCPtr, this);
  }

  public void enter(double z) {
    if (getClass() == Widget.class) libtischJNI.Widget_enter__SWIG_0(swigCPtr, this, z); else libtischJNI.Widget_enterSwigExplicitWidget__SWIG_0(swigCPtr, this, z);
  }

  public void enter() {
    if (getClass() == Widget.class) libtischJNI.Widget_enter__SWIG_1(swigCPtr, this); else libtischJNI.Widget_enterSwigExplicitWidget__SWIG_1(swigCPtr, this);
  }

  public void paint(boolean update_stencil) {
    if (getClass() == Widget.class) libtischJNI.Widget_paint__SWIG_0(swigCPtr, this, update_stencil); else libtischJNI.Widget_paintSwigExplicitWidget__SWIG_0(swigCPtr, this, update_stencil);
  }

  public void paint() {
    if (getClass() == Widget.class) libtischJNI.Widget_paint__SWIG_1(swigCPtr, this); else libtischJNI.Widget_paintSwigExplicitWidget__SWIG_1(swigCPtr, this);
  }

  public void leave() {
    libtischJNI.Widget_leave(swigCPtr, this);
  }

  public void setRegion(Region value) {
    libtischJNI.Widget_region_set(swigCPtr, this, Region.getCPtr(value), value);
  }

  public Region getRegion() {
    long cPtr = libtischJNI.Widget_region_get(swigCPtr, this);
    return (cPtr == 0) ? null : new Region(cPtr, false);
  }

  public void setShadow(boolean value) {
    libtischJNI.Widget_shadow_set(swigCPtr, this, value);
  }

  public boolean getShadow() {
    return libtischJNI.Widget_shadow_get(swigCPtr, this);
  }

  public void setHide(boolean value) {
    libtischJNI.Widget_hide_set(swigCPtr, this, value);
  }

  public boolean getHide() {
    return libtischJNI.Widget_hide_get(swigCPtr, this);
  }

  public void setW(double value) {
    libtischJNI.Widget_w_set(swigCPtr, this, value);
  }

  public double getW() {
    return libtischJNI.Widget_w_get(swigCPtr, this);
  }

  public void setH(double value) {
    libtischJNI.Widget_h_set(swigCPtr, this, value);
  }

  public double getH() {
    return libtischJNI.Widget_h_get(swigCPtr, this);
  }

  public void setX(double value) {
    libtischJNI.Widget_x_set(swigCPtr, this, value);
  }

  public double getX() {
    return libtischJNI.Widget_x_get(swigCPtr, this);
  }

  public void setY(double value) {
    libtischJNI.Widget_y_set(swigCPtr, this, value);
  }

  public double getY() {
    return libtischJNI.Widget_y_get(swigCPtr, this);
  }

  public void setSx(double value) {
    libtischJNI.Widget_sx_set(swigCPtr, this, value);
  }

  public double getSx() {
    return libtischJNI.Widget_sx_get(swigCPtr, this);
  }

  public void setSy(double value) {
    libtischJNI.Widget_sy_set(swigCPtr, this, value);
  }

  public double getSy() {
    return libtischJNI.Widget_sy_get(swigCPtr, this);
  }

  public void setAngle(double value) {
    libtischJNI.Widget_angle_set(swigCPtr, this, value);
  }

  public double getAngle() {
    return libtischJNI.Widget_angle_get(swigCPtr, this);
  }

  public void setAsx(double value) {
    libtischJNI.Widget_asx_set(swigCPtr, this, value);
  }

  public double getAsx() {
    return libtischJNI.Widget_asx_get(swigCPtr, this);
  }

  public void setAsy(double value) {
    libtischJNI.Widget_asy_set(swigCPtr, this, value);
  }

  public double getAsy() {
    return libtischJNI.Widget_asy_get(swigCPtr, this);
  }

  public void setAbsangle(double value) {
    libtischJNI.Widget_absangle_set(swigCPtr, this, value);
  }

  public double getAbsangle() {
    return libtischJNI.Widget_absangle_get(swigCPtr, this);
  }

  public void setAbspos(Vector value) {
    libtischJNI.Widget_abspos_set(swigCPtr, this, Vector.getCPtr(value), value);
  }

  public Vector getAbspos() {
    long cPtr = libtischJNI.Widget_abspos_get(swigCPtr, this);
    return (cPtr == 0) ? null : new Vector(cPtr, false);
  }

  protected void unregister() {
    libtischJNI.Widget_unregister(swigCPtr, this);
  }

  protected void setMytex(RGBATexture value) {
    libtischJNI.Widget_mytex_set(swigCPtr, this, libtischJNI.getCPtrAddRef(value), value);
  }

  protected RGBATexture getMytex() {
    long cPtr = libtischJNI.Widget_mytex_get(swigCPtr, this);
    return (cPtr == 0) ? null : new RGBATexture(cPtr, false);
  }

  protected void setMycolor(SWIGTYPE_p_GLdouble value) {
    libtischJNI.Widget_mycolor_set(swigCPtr, this, SWIGTYPE_p_GLdouble.getCPtr(value));
  }

  protected SWIGTYPE_p_GLdouble getMycolor() {
    long cPtr = libtischJNI.Widget_mycolor_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_GLdouble(cPtr, false);
  }

  protected void setParent(Container value) {
    libtischJNI.Widget_parent_set(swigCPtr, this, Container.getCPtr(value), value);
  }

  protected Container getParent() {
    long cPtr = libtischJNI.Widget_parent_get(swigCPtr, this);
    return (cPtr == 0) ? null : new Container(cPtr, false);
  }

  protected void setM_model(SWIGTYPE_p_GLdouble value) {
    libtischJNI.Widget_m_model_set(swigCPtr, this, SWIGTYPE_p_GLdouble.getCPtr(value));
  }

  protected SWIGTYPE_p_GLdouble getM_model() {
    long cPtr = libtischJNI.Widget_m_model_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_GLdouble(cPtr, false);
  }

}

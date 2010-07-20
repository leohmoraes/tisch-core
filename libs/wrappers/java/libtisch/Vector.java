/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class Vector {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected Vector(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Vector obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_Vector(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public Vector(double _x, double _y, double _z) {
    this(libtischJNI.new_Vector__SWIG_0(_x, _y, _z), true);
  }

  public Vector(double _x, double _y) {
    this(libtischJNI.new_Vector__SWIG_1(_x, _y), true);
  }

  public Vector(double _x) {
    this(libtischJNI.new_Vector__SWIG_2(_x), true);
  }

  public Vector() {
    this(libtischJNI.new_Vector__SWIG_3(), true);
  }

  public void normalize() {
    libtischJNI.Vector_normalize(swigCPtr, this);
  }

  public void set(double _x, double _y, double _z) {
    libtischJNI.Vector_set__SWIG_0(swigCPtr, this, _x, _y, _z);
  }

  public void set(double _x, double _y) {
    libtischJNI.Vector_set__SWIG_1(swigCPtr, this, _x, _y);
  }

  public void set(double _x) {
    libtischJNI.Vector_set__SWIG_2(swigCPtr, this, _x);
  }

  public void set() {
    libtischJNI.Vector_set__SWIG_3(swigCPtr, this);
  }

  public double length() {
    return libtischJNI.Vector_length(swigCPtr, this);
  }

  public void rotate(double angle) {
    libtischJNI.Vector_rotate(swigCPtr, this, angle);
  }

  public IntVector round() {
    return new IntVector(libtischJNI.Vector_round(swigCPtr, this), true);
  }

  public void setX(double value) {
    libtischJNI.Vector_x_set(swigCPtr, this, value);
  }

  public double getX() {
    return libtischJNI.Vector_x_get(swigCPtr, this);
  }

  public void setY(double value) {
    libtischJNI.Vector_y_set(swigCPtr, this, value);
  }

  public double getY() {
    return libtischJNI.Vector_y_get(swigCPtr, this);
  }

  public void setZ(double value) {
    libtischJNI.Vector_z_set(swigCPtr, this, value);
  }

  public double getZ() {
    return libtischJNI.Vector_z_get(swigCPtr, this);
  }

}

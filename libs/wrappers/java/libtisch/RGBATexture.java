/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class RGBATexture {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public RGBATexture(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(RGBATexture obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_RGBATexture(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public RGBATexture(SWIGTYPE_p_GLint w, SWIGTYPE_p_GLint h, SWIGTYPE_p_GLenum filter, SWIGTYPE_p_GLenum mode) {
    this(libtischJNI.new_RGBATexture__SWIG_0(SWIGTYPE_p_GLint.getCPtr(w), SWIGTYPE_p_GLint.getCPtr(h), SWIGTYPE_p_GLenum.getCPtr(filter), SWIGTYPE_p_GLenum.getCPtr(mode)), true);
  }

  public RGBATexture(SWIGTYPE_p_GLint w, SWIGTYPE_p_GLint h, SWIGTYPE_p_GLenum filter) {
    this(libtischJNI.new_RGBATexture__SWIG_1(SWIGTYPE_p_GLint.getCPtr(w), SWIGTYPE_p_GLint.getCPtr(h), SWIGTYPE_p_GLenum.getCPtr(filter)), true);
  }

  public RGBATexture(SWIGTYPE_p_GLint w, SWIGTYPE_p_GLint h) {
    this(libtischJNI.new_RGBATexture__SWIG_2(SWIGTYPE_p_GLint.getCPtr(w), SWIGTYPE_p_GLint.getCPtr(h)), true);
  }

  public RGBATexture(String pngfile, SWIGTYPE_p_GLenum filter, SWIGTYPE_p_GLenum mode) {
    this(libtischJNI.new_RGBATexture__SWIG_3(pngfile, SWIGTYPE_p_GLenum.getCPtr(filter), SWIGTYPE_p_GLenum.getCPtr(mode)), true);
  }

  public RGBATexture(String pngfile, SWIGTYPE_p_GLenum filter) {
    this(libtischJNI.new_RGBATexture__SWIG_4(pngfile, SWIGTYPE_p_GLenum.getCPtr(filter)), true);
  }

  public RGBATexture(String pngfile) {
    this(libtischJNI.new_RGBATexture__SWIG_5(pngfile), true);
  }

  public void render(SWIGTYPE_p_GLint texels, SWIGTYPE_p_GLenum where, SWIGTYPE_p_GLfloat z) {
    libtischJNI.RGBATexture_render__SWIG_0(swigCPtr, this, SWIGTYPE_p_GLint.getCPtr(texels), SWIGTYPE_p_GLenum.getCPtr(where), SWIGTYPE_p_GLfloat.getCPtr(z));
  }

  public void render(SWIGTYPE_p_GLint texels, SWIGTYPE_p_GLenum where) {
    libtischJNI.RGBATexture_render__SWIG_1(swigCPtr, this, SWIGTYPE_p_GLint.getCPtr(texels), SWIGTYPE_p_GLenum.getCPtr(where));
  }

  public void render(SWIGTYPE_p_GLint texels) {
    libtischJNI.RGBATexture_render__SWIG_2(swigCPtr, this, SWIGTYPE_p_GLint.getCPtr(texels));
  }

  public void render() {
    libtischJNI.RGBATexture_render__SWIG_3(swigCPtr, this);
  }

  public void bind(SWIGTYPE_p_GLenum where) {
    libtischJNI.RGBATexture_bind__SWIG_0(swigCPtr, this, SWIGTYPE_p_GLenum.getCPtr(where));
  }

  public void bind() {
    libtischJNI.RGBATexture_bind__SWIG_1(swigCPtr, this);
  }

  public void release() {
    libtischJNI.RGBATexture_release(swigCPtr, this);
  }

  public SWIGTYPE_p_GLuint get() {
    return new SWIGTYPE_p_GLuint(libtischJNI.RGBATexture_get(swigCPtr, this), true);
  }

  public SWIGTYPE_p_GLint width(int orig) {
    return new SWIGTYPE_p_GLint(libtischJNI.RGBATexture_width__SWIG_0(swigCPtr, this, orig), true);
  }

  public SWIGTYPE_p_GLint width() {
    return new SWIGTYPE_p_GLint(libtischJNI.RGBATexture_width__SWIG_1(swigCPtr, this), true);
  }

  public SWIGTYPE_p_GLint height(int orig) {
    return new SWIGTYPE_p_GLint(libtischJNI.RGBATexture_height__SWIG_0(swigCPtr, this, orig), true);
  }

  public SWIGTYPE_p_GLint height() {
    return new SWIGTYPE_p_GLint(libtischJNI.RGBATexture_height__SWIG_1(swigCPtr, this), true);
  }

  public void load(SWIGTYPE_p_GLvoid data, SWIGTYPE_p_GLenum data_format, SWIGTYPE_p_GLenum data_type) {
    libtischJNI.RGBATexture_load__SWIG_0(swigCPtr, this, SWIGTYPE_p_GLvoid.getCPtr(data), SWIGTYPE_p_GLenum.getCPtr(data_format), SWIGTYPE_p_GLenum.getCPtr(data_type));
  }

  public void load(String pngfile) {
    libtischJNI.RGBATexture_load__SWIG_1(swigCPtr, this, pngfile);
  }

  public void load(SWIGTYPE_p_IntensityImage img) {
    libtischJNI.RGBATexture_load__SWIG_2(swigCPtr, this, SWIGTYPE_p_IntensityImage.getCPtr(img));
  }

  public void load(SWIGTYPE_p_ShortImage img) {
    libtischJNI.RGBATexture_load__SWIG_3(swigCPtr, this, SWIGTYPE_p_ShortImage.getCPtr(img));
  }

  public void load(SWIGTYPE_p_RGBImage img) {
    libtischJNI.RGBATexture_load__SWIG_4(swigCPtr, this, SWIGTYPE_p_RGBImage.getCPtr(img));
  }

  public void read(SWIGTYPE_p_GLvoid data) {
    libtischJNI.RGBATexture_read(swigCPtr, this, SWIGTYPE_p_GLvoid.getCPtr(data));
  }

}

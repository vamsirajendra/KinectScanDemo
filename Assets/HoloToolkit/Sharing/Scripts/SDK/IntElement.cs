//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace HoloToolkit.Sharing {

public class IntElement : Element {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal IntElement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.IntElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IntElement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_IntElement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static IntElement Cast(Element element) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.IntElement_Cast(Element.getCPtr(element));
    IntElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntElement(cPtr, true);
    return ret; 
  }

  public virtual int GetValue() {
    int ret = SharingClientPINVOKE.IntElement_GetValue(swigCPtr);
    return ret;
  }

  public virtual void SetValue(int newValue) {
    SharingClientPINVOKE.IntElement_SetValue(swigCPtr, newValue);
  }

}

}

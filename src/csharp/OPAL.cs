//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class OPAL {
  public static SWIGTYPE_p_OpalHandleStruct OpalInitialise(SWIGTYPE_p_unsigned_int version, string options) {
    global::System.IntPtr cPtr = OPALPINVOKE.OpalInitialise(SWIGTYPE_p_unsigned_int.getCPtr(version), options);
    SWIGTYPE_p_OpalHandleStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_OpalHandleStruct(cPtr, false);
    return ret;
  }

  public static void OpalShutDown(SWIGTYPE_p_OpalHandleStruct opal) {
    OPALPINVOKE.OpalShutDown(SWIGTYPE_p_OpalHandleStruct.getCPtr(opal));
  }

  public static SWIGTYPE_p_OpalMessage OpalGetMessage(SWIGTYPE_p_OpalHandleStruct opal, uint timeout) {
    global::System.IntPtr cPtr = OPALPINVOKE.OpalGetMessage(SWIGTYPE_p_OpalHandleStruct.getCPtr(opal), timeout);
    SWIGTYPE_p_OpalMessage ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_OpalMessage(cPtr, false);
    return ret;
  }

  public static SWIGTYPE_p_OpalMessage OpalSendMessage(SWIGTYPE_p_OpalHandleStruct opal, SWIGTYPE_p_OpalMessage message) {
    global::System.IntPtr cPtr = OPALPINVOKE.OpalSendMessage(SWIGTYPE_p_OpalHandleStruct.getCPtr(opal), SWIGTYPE_p_OpalMessage.getCPtr(message));
    SWIGTYPE_p_OpalMessage ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_OpalMessage(cPtr, false);
    return ret;
  }

  public static void OpalFreeMessage(SWIGTYPE_p_OpalMessage message) {
    OPALPINVOKE.OpalFreeMessage(SWIGTYPE_p_OpalMessage.getCPtr(message));
  }

  public static readonly int OPAL_C_API_VERSION = OPALPINVOKE.OPAL_C_API_VERSION_get();
  public static readonly string OPAL_INITIALISE_FUNCTION = OPALPINVOKE.OPAL_INITIALISE_FUNCTION_get();
  public static readonly string OPAL_SHUTDOWN_FUNCTION = OPALPINVOKE.OPAL_SHUTDOWN_FUNCTION_get();
  public static readonly string OPAL_GET_MESSAGE_FUNCTION = OPALPINVOKE.OPAL_GET_MESSAGE_FUNCTION_get();
  public static readonly string OPAL_SEND_MESSAGE_FUNCTION = OPALPINVOKE.OPAL_SEND_MESSAGE_FUNCTION_get();
  public static readonly string OPAL_FREE_MESSAGE_FUNCTION = OPALPINVOKE.OPAL_FREE_MESSAGE_FUNCTION_get();
  public static readonly string OPAL_PREFIX_H323 = OPALPINVOKE.OPAL_PREFIX_H323_get();
  public static readonly string OPAL_PREFIX_H323S = OPALPINVOKE.OPAL_PREFIX_H323S_get();
  public static readonly string OPAL_PREFIX_SIP = OPALPINVOKE.OPAL_PREFIX_SIP_get();
  public static readonly string OPAL_PREFIX_SIPS = OPALPINVOKE.OPAL_PREFIX_SIPS_get();
  public static readonly string OPAL_PREFIX_SDP = OPALPINVOKE.OPAL_PREFIX_SDP_get();
  public static readonly string OPAL_PREFIX_IAX2 = OPALPINVOKE.OPAL_PREFIX_IAX2_get();
  public static readonly string OPAL_PREFIX_PCSS = OPALPINVOKE.OPAL_PREFIX_PCSS_get();
  public static readonly string OPAL_PREFIX_LOCAL = OPALPINVOKE.OPAL_PREFIX_LOCAL_get();
  public static readonly string OPAL_PREFIX_POTS = OPALPINVOKE.OPAL_PREFIX_POTS_get();
  public static readonly string OPAL_PREFIX_PSTN = OPALPINVOKE.OPAL_PREFIX_PSTN_get();
  public static readonly string OPAL_PREFIX_CAPI = OPALPINVOKE.OPAL_PREFIX_CAPI_get();
  public static readonly string OPAL_PREFIX_FAX = OPALPINVOKE.OPAL_PREFIX_FAX_get();
  public static readonly string OPAL_PREFIX_T38 = OPALPINVOKE.OPAL_PREFIX_T38_get();
  public static readonly string OPAL_PREFIX_IVR = OPALPINVOKE.OPAL_PREFIX_IVR_get();
  public static readonly string OPAL_PREFIX_MIXER = OPALPINVOKE.OPAL_PREFIX_MIXER_get();
  public static readonly string OPAL_PREFIX_IM = OPALPINVOKE.OPAL_PREFIX_IM_get();
  public static readonly string OPAL_PREFIX_GST = OPALPINVOKE.OPAL_PREFIX_GST_get();
  public static readonly string OPAL_PREFIX_SKINNY = OPALPINVOKE.OPAL_PREFIX_SKINNY_get();
  public static readonly string OPAL_PREFIX_LYNC = OPALPINVOKE.OPAL_PREFIX_LYNC_get();
  public static readonly string OPAL_PREFIX_ALL = OPALPINVOKE.OPAL_PREFIX_ALL_get();
  public static readonly string OPAL_MWI_EVENT_PACKAGE = OPALPINVOKE.OPAL_MWI_EVENT_PACKAGE_get();
  public static readonly string OPAL_LINE_APPEARANCE_EVENT_PACKAGE = OPALPINVOKE.OPAL_LINE_APPEARANCE_EVENT_PACKAGE_get();
}
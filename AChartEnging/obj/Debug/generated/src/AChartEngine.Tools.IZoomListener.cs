using System;
using System.Collections.Generic;
using Android.Runtime;

namespace AChartEngine.Tools {

	[Register ("org/achartengine/tools/ZoomListener", "", "AChartEngine.Tools.IZoomListenerInvoker")]
	public partial interface IZoomListener : IJavaObject {

		[Register ("zoomApplied", "(Lorg/achartengine/tools/ZoomEvent;)V", "GetZoomApplied_Lorg_achartengine_tools_ZoomEvent_Handler:AChartEngine.Tools.IZoomListenerInvoker, AChartEnging")]
		void ZoomApplied (global::AChartEngine.Tools.ZoomEvent p0);

		[Register ("zoomReset", "()V", "GetZoomResetHandler:AChartEngine.Tools.IZoomListenerInvoker, AChartEnging")]
		void ZoomReset ();

	}

	[global::Android.Runtime.Register ("org/achartengine/tools/ZoomListener", DoNotGenerateAcw=true)]
	internal class IZoomListenerInvoker : global::Java.Lang.Object, IZoomListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/achartengine/tools/ZoomListener");
		IntPtr class_ref;

		public static IZoomListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IZoomListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.achartengine.tools.ZoomListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IZoomListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IZoomListenerInvoker); }
		}

		static Delegate cb_zoomApplied_Lorg_achartengine_tools_ZoomEvent_;
#pragma warning disable 0169
		static Delegate GetZoomApplied_Lorg_achartengine_tools_ZoomEvent_Handler ()
		{
			if (cb_zoomApplied_Lorg_achartengine_tools_ZoomEvent_ == null)
				cb_zoomApplied_Lorg_achartengine_tools_ZoomEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ZoomApplied_Lorg_achartengine_tools_ZoomEvent_);
			return cb_zoomApplied_Lorg_achartengine_tools_ZoomEvent_;
		}

		static void n_ZoomApplied_Lorg_achartengine_tools_ZoomEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::AChartEngine.Tools.IZoomListener __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Tools.IZoomListener> (native__this, JniHandleOwnership.DoNotTransfer);
			global::AChartEngine.Tools.ZoomEvent p0 = global::Java.Lang.Object.GetObject<global::AChartEngine.Tools.ZoomEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ZoomApplied (p0);
		}
#pragma warning restore 0169

		IntPtr id_zoomApplied_Lorg_achartengine_tools_ZoomEvent_;
		public void ZoomApplied (global::AChartEngine.Tools.ZoomEvent p0)
		{
			if (id_zoomApplied_Lorg_achartengine_tools_ZoomEvent_ == IntPtr.Zero)
				id_zoomApplied_Lorg_achartengine_tools_ZoomEvent_ = JNIEnv.GetMethodID (class_ref, "zoomApplied", "(Lorg/achartengine/tools/ZoomEvent;)V");
			JNIEnv.CallVoidMethod (Handle, id_zoomApplied_Lorg_achartengine_tools_ZoomEvent_, new JValue (p0));
		}

		static Delegate cb_zoomReset;
#pragma warning disable 0169
		static Delegate GetZoomResetHandler ()
		{
			if (cb_zoomReset == null)
				cb_zoomReset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomReset);
			return cb_zoomReset;
		}

		static void n_ZoomReset (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Tools.IZoomListener __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Tools.IZoomListener> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomReset ();
		}
#pragma warning restore 0169

		IntPtr id_zoomReset;
		public void ZoomReset ()
		{
			if (id_zoomReset == IntPtr.Zero)
				id_zoomReset = JNIEnv.GetMethodID (class_ref, "zoomReset", "()V");
			JNIEnv.CallVoidMethod (Handle, id_zoomReset);
		}

	}

	public partial class ZoomAppliedEventArgs : global::System.EventArgs {

		public ZoomAppliedEventArgs (global::AChartEngine.Tools.ZoomEvent p0)
		{
			this.p0 = p0;
		}

		global::AChartEngine.Tools.ZoomEvent p0;
		public global::AChartEngine.Tools.ZoomEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/achartengine/tools/ZoomListenerImplementor")]
	internal sealed class IZoomListenerImplementor : global::Java.Lang.Object, IZoomListener {

		object sender;

		public IZoomListenerImplementor (object sender)
			: base (global::Android.Runtime.JNIEnv.CreateInstance ("mono/org/achartengine/tools/ZoomListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ZoomAppliedEventArgs> ZoomAppliedHandler;
#pragma warning restore 0649

		public void ZoomApplied (global::AChartEngine.Tools.ZoomEvent p0)
		{
			if (ZoomAppliedHandler != null)
				ZoomAppliedHandler (sender, new ZoomAppliedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler ZoomResetHandler;
#pragma warning restore 0649

		public void ZoomReset ()
		{
			if (ZoomResetHandler != null)
				ZoomResetHandler (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IZoomListenerImplementor value)
		{
			return value.ZoomAppliedHandler == null && value.ZoomResetHandler == null;
		}
	}

}

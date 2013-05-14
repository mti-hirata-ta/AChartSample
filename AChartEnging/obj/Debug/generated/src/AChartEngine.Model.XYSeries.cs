using System;
using System.Collections.Generic;
using Android.Runtime;

namespace AChartEngine.Model {

	[global::Android.Runtime.Register ("org/achartengine/model/XYSeries", DoNotGenerateAcw=true)]
	public partial class XYSeries : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/XYSeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYSeries); }
		}

		protected XYSeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_I;
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public XYSeries (string p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (XYSeries)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public XYSeries (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (XYSeries)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public virtual int ItemCount {
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getItemCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getItemCount);
			}
		}

		static Delegate cb_getMaxX;
#pragma warning disable 0169
		static Delegate GetGetMaxXHandler ()
		{
			if (cb_getMaxX == null)
				cb_getMaxX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxX);
			return cb_getMaxX;
		}

		static double n_GetMaxX (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxX;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxX;
		public virtual double MaxX {
			[Register ("getMaxX", "()D", "GetGetMaxXHandler")]
			get {
				if (id_getMaxX == IntPtr.Zero)
					id_getMaxX = JNIEnv.GetMethodID (class_ref, "getMaxX", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaxX);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMaxX);
			}
		}

		static Delegate cb_getMaxY;
#pragma warning disable 0169
		static Delegate GetGetMaxYHandler ()
		{
			if (cb_getMaxY == null)
				cb_getMaxY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxY);
			return cb_getMaxY;
		}

		static double n_GetMaxY (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxY;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxY;
		public virtual double MaxY {
			[Register ("getMaxY", "()D", "GetGetMaxYHandler")]
			get {
				if (id_getMaxY == IntPtr.Zero)
					id_getMaxY = JNIEnv.GetMethodID (class_ref, "getMaxY", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaxY);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMaxY);
			}
		}

		static Delegate cb_getMinX;
#pragma warning disable 0169
		static Delegate GetGetMinXHandler ()
		{
			if (cb_getMinX == null)
				cb_getMinX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinX);
			return cb_getMinX;
		}

		static double n_GetMinX (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinX;
		}
#pragma warning restore 0169

		static IntPtr id_getMinX;
		public virtual double MinX {
			[Register ("getMinX", "()D", "GetGetMinXHandler")]
			get {
				if (id_getMinX == IntPtr.Zero)
					id_getMinX = JNIEnv.GetMethodID (class_ref, "getMinX", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMinX);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMinX);
			}
		}

		static Delegate cb_getMinY;
#pragma warning disable 0169
		static Delegate GetGetMinYHandler ()
		{
			if (cb_getMinY == null)
				cb_getMinY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinY);
			return cb_getMinY;
		}

		static double n_GetMinY (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinY;
		}
#pragma warning restore 0169

		static IntPtr id_getMinY;
		public virtual double MinY {
			[Register ("getMinY", "()D", "GetGetMinYHandler")]
			get {
				if (id_getMinY == IntPtr.Zero)
					id_getMinY = JNIEnv.GetMethodID (class_ref, "getMinY", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMinY);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMinY);
			}
		}

		static Delegate cb_getScaleNumber;
#pragma warning disable 0169
		static Delegate GetGetScaleNumberHandler ()
		{
			if (cb_getScaleNumber == null)
				cb_getScaleNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScaleNumber);
			return cb_getScaleNumber;
		}

		static int n_GetScaleNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleNumber;
		public virtual int ScaleNumber {
			[Register ("getScaleNumber", "()I", "GetGetScaleNumberHandler")]
			get {
				if (id_getScaleNumber == IntPtr.Zero)
					id_getScaleNumber = JNIEnv.GetMethodID (class_ref, "getScaleNumber", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getScaleNumber);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getScaleNumber);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual string Title {
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_add_DD;
#pragma warning disable 0169
		static Delegate GetAdd_DDHandler ()
		{
			if (cb_add_DD == null)
				cb_add_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_Add_DD);
			return cb_add_DD;
		}

		static void n_Add_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_DD;
		[Register ("add", "(DD)V", "GetAdd_DDHandler")]
		public virtual void Add (double p0, double p1)
		{
			if (id_add_DD == IntPtr.Zero)
				id_add_DD = JNIEnv.GetMethodID (class_ref, "add", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_DD, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clear);
		}

		static Delegate cb_getIndexForKey_D;
#pragma warning disable 0169
		static Delegate GetGetIndexForKey_DHandler ()
		{
			if (cb_getIndexForKey_D == null)
				cb_getIndexForKey_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, int>) n_GetIndexForKey_D);
			return cb_getIndexForKey_D;
		}

		static int n_GetIndexForKey_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexForKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getIndexForKey_D;
		[Register ("getIndexForKey", "(D)I", "GetGetIndexForKey_DHandler")]
		public virtual int GetIndexForKey (double p0)
		{
			if (id_getIndexForKey_D == IntPtr.Zero)
				id_getIndexForKey_D = JNIEnv.GetMethodID (class_ref, "getIndexForKey", "(D)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getIndexForKey_D, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getIndexForKey_D, new JValue (p0));
		}

		static Delegate cb_getRange_DDI;
#pragma warning disable 0169
		static Delegate GetGetRange_DDIHandler ()
		{
			if (cb_getRange_DDI == null)
				cb_getRange_DDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, int, IntPtr>) n_GetRange_DDI);
			return cb_getRange_DDI;
		}

		static IntPtr n_GetRange_DDI (IntPtr jnienv, IntPtr native__this, double p0, double p1, int p2)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Java.Lang.Double, global::Java.Lang.Double>.ToLocalJniHandle (__this.GetRange (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getRange_DDI;
		[Register ("getRange", "(DDI)Ljava/util/SortedMap;", "GetGetRange_DDIHandler")]
		public virtual global::System.Collections.Generic.IDictionary<global::Java.Lang.Double, global::Java.Lang.Double> GetRange (double p0, double p1, int p2)
		{
			if (id_getRange_DDI == IntPtr.Zero)
				id_getRange_DDI = JNIEnv.GetMethodID (class_ref, "getRange", "(DDI)Ljava/util/SortedMap;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Double, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRange_DDI, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Double, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRange_DDI, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getX_I;
#pragma warning disable 0169
		static Delegate GetGetX_IHandler ()
		{
			if (cb_getX_I == null)
				cb_getX_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetX_I);
			return cb_getX_I;
		}

		static double n_GetX_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getX_I;
		[Register ("getX", "(I)D", "GetGetX_IHandler")]
		public virtual double GetX (int p0)
		{
			if (id_getX_I == IntPtr.Zero)
				id_getX_I = JNIEnv.GetMethodID (class_ref, "getX", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getX_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getX_I, new JValue (p0));
		}

		static Delegate cb_getY_I;
#pragma warning disable 0169
		static Delegate GetGetY_IHandler ()
		{
			if (cb_getY_I == null)
				cb_getY_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetY_I);
			return cb_getY_I;
		}

		static double n_GetY_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getY_I;
		[Register ("getY", "(I)D", "GetGetY_IHandler")]
		public virtual double GetY (int p0)
		{
			if (id_getY_I == IntPtr.Zero)
				id_getY_I = JNIEnv.GetMethodID (class_ref, "getY", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getY_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getY_I, new JValue (p0));
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::AChartEngine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::AChartEngine.Model.XYSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_remove_I, new JValue (p0));
		}

	}
}

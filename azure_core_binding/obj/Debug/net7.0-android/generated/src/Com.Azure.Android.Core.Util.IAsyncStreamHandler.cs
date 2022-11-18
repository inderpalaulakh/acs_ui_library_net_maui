using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStreamHandler']"
	[Register ("com/azure/android/core/util/AsyncStreamHandler", "", "Com.Azure.Android.Core.Util.IAsyncStreamHandlerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IAsyncStreamHandler : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/AsyncStreamHandler", typeof (IAsyncStreamHandler), isInterface: true);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStreamHandler']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onNext", "(Ljava/lang/Object;)V", "GetOnNext_Ljava_lang_Object_Handler:Com.Azure.Android.Core.Util.IAsyncStreamHandlerInvoker, azure_core_binding")]
		void OnNext (global::Java.Lang.Object? p0);

		private static Delegate? cb_onComplete;
#pragma warning disable 0169
		private static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		private static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStreamHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStreamHandler']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler:Com.Azure.Android.Core.Util.IAsyncStreamHandler, azure_core_binding")]
		virtual unsafe void OnComplete ()
		{
			const string __id = "onComplete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		private static Delegate? cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		private static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		private static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStreamHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.OnError (throwable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStreamHandler']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Azure.Android.Core.Util.IAsyncStreamHandler, azure_core_binding")]
		virtual unsafe void OnError (global::Java.Lang.Throwable? throwable)
		{
			const string __id = "onError.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		private static Delegate? cb_onInit_Lcom_azure_android_core_util_CancellationToken_;
#pragma warning disable 0169
		private static Delegate GetOnInit_Lcom_azure_android_core_util_CancellationToken_Handler ()
		{
			if (cb_onInit_Lcom_azure_android_core_util_CancellationToken_ == null)
				cb_onInit_Lcom_azure_android_core_util_CancellationToken_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnInit_Lcom_azure_android_core_util_CancellationToken_);
			return cb_onInit_Lcom_azure_android_core_util_CancellationToken_;
		}

		private static void n_OnInit_Lcom_azure_android_core_util_CancellationToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cancellationToken)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStreamHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cancellationToken = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.CancellationToken> (native_cancellationToken, JniHandleOwnership.DoNotTransfer);
			__this.OnInit (cancellationToken);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStreamHandler']/method[@name='onInit' and count(parameter)=1 and parameter[1][@type='com.azure.android.core.util.CancellationToken']]"
		[Register ("onInit", "(Lcom/azure/android/core/util/CancellationToken;)V", "GetOnInit_Lcom_azure_android_core_util_CancellationToken_Handler:Com.Azure.Android.Core.Util.IAsyncStreamHandler, azure_core_binding")]
		virtual unsafe void OnInit (global::Com.Azure.Android.Core.Util.CancellationToken? cancellationToken)
		{
			const string __id = "onInit.(Lcom/azure/android/core/util/CancellationToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cancellationToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cancellationToken).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cancellationToken);
			}
		}

	}

	[global::Android.Runtime.Register ("com/azure/android/core/util/AsyncStreamHandler", DoNotGenerateAcw=true)]
	internal partial class IAsyncStreamHandlerInvoker : global::Java.Lang.Object, IAsyncStreamHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/AsyncStreamHandler", typeof (IAsyncStreamHandlerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAsyncStreamHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncStreamHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.azure.android.core.util.AsyncStreamHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncStreamHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onNext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnNext_Ljava_lang_Object_Handler ()
		{
			if (cb_onNext_Ljava_lang_Object_ == null)
				cb_onNext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNext_Ljava_lang_Object_);
			return cb_onNext_Ljava_lang_Object_;
		}

		static void n_OnNext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStreamHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNext (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNext_Ljava_lang_Object_;
		public unsafe void OnNext (global::Java.Lang.Object? p0)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']"
	[global::Android.Runtime.Register ("com/azure/android/core/logging/ClientLogger", DoNotGenerateAcw=true)]
	public partial class ClientLogger : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/logging/ClientLogger", typeof (ClientLogger));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ClientLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/constructor[@name='ClientLogger' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe ClientLogger (global::Java.Lang.Class? clazz) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/constructor[@name='ClientLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ClientLogger (string? className) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_className = JNIEnv.NewString ((string?)className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_className);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		static Delegate? cb_canLogAtLevel_Lcom_azure_android_core_logging_LogLevel_;
#pragma warning disable 0169
		static Delegate GetCanLogAtLevel_Lcom_azure_android_core_logging_LogLevel_Handler ()
		{
			if (cb_canLogAtLevel_Lcom_azure_android_core_logging_LogLevel_ == null)
				cb_canLogAtLevel_Lcom_azure_android_core_logging_LogLevel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanLogAtLevel_Lcom_azure_android_core_logging_LogLevel_);
			return cb_canLogAtLevel_Lcom_azure_android_core_logging_LogLevel_;
		}

		static bool n_CanLogAtLevel_Lcom_azure_android_core_logging_LogLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logLevel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var logLevel = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (native_logLevel, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanLogAtLevel (logLevel);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='canLogAtLevel' and count(parameter)=1 and parameter[1][@type='com.azure.android.core.logging.LogLevel']]"
		[Register ("canLogAtLevel", "(Lcom/azure/android/core/logging/LogLevel;)Z", "GetCanLogAtLevel_Lcom_azure_android_core_logging_LogLevel_Handler")]
		public virtual unsafe bool CanLogAtLevel (global::Com.Azure.Android.Core.Logging.LogLevel? logLevel)
		{
			const string __id = "canLogAtLevel.(Lcom/azure/android/core/logging/LogLevel;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (logLevel);
			}
		}

		static Delegate? cb_error_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Handler ()
		{
			if (cb_error_Ljava_lang_String_ == null)
				cb_error_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Error_Ljava_lang_String_);
			return cb_error_Ljava_lang_String_;
		}

		static void n_Error_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Error (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "GetError_Ljava_lang_String_Handler")]
		public virtual unsafe void Error (string? message)
		{
			const string __id = "error.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate? cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_error_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Error (format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("error", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Error (string? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "error.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		static Delegate? cb_info_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Info_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_;
		}

		static void n_Info_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Info (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "GetInfo_Ljava_lang_String_Handler")]
		public virtual unsafe void Info (string? message)
		{
			const string __id = "info.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate? cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Info (string? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "info.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		static Delegate? cb_logExceptionAsError_Ljava_lang_RuntimeException_;
#pragma warning disable 0169
		static Delegate GetLogExceptionAsError_Ljava_lang_RuntimeException_Handler ()
		{
			if (cb_logExceptionAsError_Ljava_lang_RuntimeException_ == null)
				cb_logExceptionAsError_Ljava_lang_RuntimeException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LogExceptionAsError_Ljava_lang_RuntimeException_);
			return cb_logExceptionAsError_Ljava_lang_RuntimeException_;
		}

		static IntPtr n_LogExceptionAsError_Ljava_lang_RuntimeException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runtimeException)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var runtimeException = global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (native_runtimeException, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogExceptionAsError (runtimeException));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='logExceptionAsError' and count(parameter)=1 and parameter[1][@type='java.lang.RuntimeException']]"
		[Register ("logExceptionAsError", "(Ljava/lang/RuntimeException;)Ljava/lang/RuntimeException;", "GetLogExceptionAsError_Ljava_lang_RuntimeException_Handler")]
		public virtual unsafe global::Java.Lang.RuntimeException? LogExceptionAsError (global::Java.Lang.RuntimeException? runtimeException)
		{
			const string __id = "logExceptionAsError.(Ljava/lang/RuntimeException;)Ljava/lang/RuntimeException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runtimeException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) runtimeException).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (runtimeException);
			}
		}

		static Delegate? cb_logExceptionAsWarning_Ljava_lang_RuntimeException_;
#pragma warning disable 0169
		static Delegate GetLogExceptionAsWarning_Ljava_lang_RuntimeException_Handler ()
		{
			if (cb_logExceptionAsWarning_Ljava_lang_RuntimeException_ == null)
				cb_logExceptionAsWarning_Ljava_lang_RuntimeException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LogExceptionAsWarning_Ljava_lang_RuntimeException_);
			return cb_logExceptionAsWarning_Ljava_lang_RuntimeException_;
		}

		static IntPtr n_LogExceptionAsWarning_Ljava_lang_RuntimeException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runtimeException)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var runtimeException = global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (native_runtimeException, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogExceptionAsWarning (runtimeException));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='logExceptionAsWarning' and count(parameter)=1 and parameter[1][@type='java.lang.RuntimeException']]"
		[Register ("logExceptionAsWarning", "(Ljava/lang/RuntimeException;)Ljava/lang/RuntimeException;", "GetLogExceptionAsWarning_Ljava_lang_RuntimeException_Handler")]
		public virtual unsafe global::Java.Lang.RuntimeException? LogExceptionAsWarning (global::Java.Lang.RuntimeException? runtimeException)
		{
			const string __id = "logExceptionAsWarning.(Ljava/lang/RuntimeException;)Ljava/lang/RuntimeException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runtimeException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) runtimeException).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (runtimeException);
			}
		}

		static Delegate? cb_logThrowableAsError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLogThrowableAsError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_logThrowableAsError_Ljava_lang_Throwable_ == null)
				cb_logThrowableAsError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LogThrowableAsError_Ljava_lang_Throwable_);
			return cb_logThrowableAsError_Ljava_lang_Throwable_;
		}

		static IntPtr n_LogThrowableAsError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_throwable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogThrowableAsError (throwable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='logThrowableAsError' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("logThrowableAsError", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", "GetLogThrowableAsError_Ljava_lang_Throwable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Throwable"})]
		public virtual unsafe global::Java.Lang.Object? LogThrowableAsError (global::Java.Lang.Object? throwable)
		{
			const string __id = "logThrowableAsError.(Ljava/lang/Throwable;)Ljava/lang/Throwable;";
			IntPtr native_throwable = JNIEnv.ToLocalJniHandle (throwable);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_throwable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_throwable);
				global::System.GC.KeepAlive (throwable);
			}
		}

		static Delegate? cb_logThrowableAsWarning_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLogThrowableAsWarning_Ljava_lang_Throwable_Handler ()
		{
			if (cb_logThrowableAsWarning_Ljava_lang_Throwable_ == null)
				cb_logThrowableAsWarning_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LogThrowableAsWarning_Ljava_lang_Throwable_);
			return cb_logThrowableAsWarning_Ljava_lang_Throwable_;
		}

		static IntPtr n_LogThrowableAsWarning_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_throwable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LogThrowableAsWarning (throwable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='logThrowableAsWarning' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("logThrowableAsWarning", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", "GetLogThrowableAsWarning_Ljava_lang_Throwable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Throwable"})]
		public virtual unsafe global::Java.Lang.Object? LogThrowableAsWarning (global::Java.Lang.Object? throwable)
		{
			const string __id = "logThrowableAsWarning.(Ljava/lang/Throwable;)Ljava/lang/Throwable;";
			IntPtr native_throwable = JNIEnv.ToLocalJniHandle (throwable);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_throwable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_throwable);
				global::System.GC.KeepAlive (throwable);
			}
		}

		static Delegate? cb_verbose_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetVerbose_Ljava_lang_String_Handler ()
		{
			if (cb_verbose_Ljava_lang_String_ == null)
				cb_verbose_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Verbose_Ljava_lang_String_);
			return cb_verbose_Ljava_lang_String_;
		}

		static void n_Verbose_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Verbose (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='verbose' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("verbose", "(Ljava/lang/String;)V", "GetVerbose_Ljava_lang_String_Handler")]
		public virtual unsafe void Verbose (string? message)
		{
			const string __id = "verbose.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate? cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetVerbose_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Verbose_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Verbose_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Verbose (format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='verbose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("verbose", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetVerbose_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Verbose (string? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "verbose.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		static Delegate? cb_warning_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Handler ()
		{
			if (cb_warning_Ljava_lang_String_ == null)
				cb_warning_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Warning_Ljava_lang_String_);
			return cb_warning_Ljava_lang_String_;
		}

		static void n_Warning_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Warning (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='warning' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warning", "(Ljava/lang/String;)V", "GetWarning_Ljava_lang_String_Handler")]
		public virtual unsafe void Warning (string? message)
		{
			const string __id = "warning.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate? cb_warning_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warning_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warning_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warning_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warning_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warning_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_args)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.ClientLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var args = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warning (format, args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='ClientLogger']/method[@name='warning' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("warning", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarning_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Warning (string? format, params global::Java.Lang.Object[]? args)
		{
			const string __id = "warning.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_args);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

	}
}

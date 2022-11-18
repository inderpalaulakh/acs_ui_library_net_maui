using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Logging.Implementation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']"
	[global::Android.Runtime.Register ("com/azure/android/core/logging/implementation/DefaultLogger", DoNotGenerateAcw=true)]
	public sealed partial class DefaultLogger : global::Org.Slf4j.Helpers.MarkerIgnoringBase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/logging/implementation/DefaultLogger", typeof (DefaultLogger));

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

		internal DefaultLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/constructor[@name='DefaultLogger' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe DefaultLogger (global::Java.Lang.Class? clazz) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/constructor[@name='DefaultLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DefaultLogger (string? name) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		public override unsafe bool IsDebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='isDebugEnabled' and count(parameter)=0]"
			[Register ("isDebugEnabled", "()Z", "")]
			get {
				const string __id = "isDebugEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsErrorEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='isErrorEnabled' and count(parameter)=0]"
			[Register ("isErrorEnabled", "()Z", "")]
			get {
				const string __id = "isErrorEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsInfoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='isInfoEnabled' and count(parameter)=0]"
			[Register ("isInfoEnabled", "()Z", "")]
			get {
				const string __id = "isInfoEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsTraceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='isTraceEnabled' and count(parameter)=0]"
			[Register ("isTraceEnabled", "()Z", "")]
			get {
				const string __id = "isTraceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsWarnEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='isWarnEnabled' and count(parameter)=0]"
			[Register ("isWarnEnabled", "()Z", "")]
			get {
				const string __id = "isWarnEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public override unsafe void Debug (string? msg)
		{
			const string __id = "debug.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override unsafe void Debug (string? format, global::Java.Lang.Object? arg1)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='debug' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override unsafe void Debug (string? format, global::Java.Lang.Object? param1, global::Java.Lang.Object? param2)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((param1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param1).Handle);
				__args [2] = new JniArgumentValue ((param2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (param1);
				global::System.GC.KeepAlive (param2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("debug", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override unsafe void Debug (string? format, global::Java.Lang.Object[]? argArray)
		{
			const string __id = "debug.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override unsafe void Debug (string? msg, global::Java.Lang.Throwable? t)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public override unsafe void Error (string? msg)
		{
			const string __id = "error.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override unsafe void Error (string? format, global::Java.Lang.Object? arg)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override unsafe void Error (string? format, global::Java.Lang.Object? arg1, global::Java.Lang.Object? arg2)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("error", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override unsafe void Error (string? format, global::Java.Lang.Object[]? argArray)
		{
			const string __id = "error.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override unsafe void Error (string? msg, global::Java.Lang.Throwable? t)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "")]
		public override unsafe void Info (string? msg)
		{
			const string __id = "info.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override unsafe void Info (string? format, global::Java.Lang.Object? arg)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override unsafe void Info (string? format, global::Java.Lang.Object? arg1, global::Java.Lang.Object? arg2)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override unsafe void Info (string? format, global::Java.Lang.Object[]? argArray)
		{
			const string __id = "info.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override unsafe void Info (string? msg, global::Java.Lang.Throwable? t)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='trace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trace", "(Ljava/lang/String;)V", "")]
		public override unsafe void Trace (string? msg)
		{
			const string __id = "trace.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override unsafe void Trace (string? format, global::Java.Lang.Object? param1)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((param1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (param1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='trace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override unsafe void Trace (string? format, global::Java.Lang.Object? param1, global::Java.Lang.Object? param2)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((param1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param1).Handle);
				__args [2] = new JniArgumentValue ((param2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) param2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (param1);
				global::System.GC.KeepAlive (param2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("trace", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override unsafe void Trace (string? format, global::Java.Lang.Object[]? argArray)
		{
			const string __id = "trace.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override unsafe void Trace (string? msg, global::Java.Lang.Throwable? t)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public override unsafe void Warn (string? msg)
		{
			const string __id = "warn.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override unsafe void Warn (string? format, global::Java.Lang.Object? arg)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override unsafe void Warn (string? format, global::Java.Lang.Object? arg1, global::Java.Lang.Object? arg2)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("warn", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override unsafe void Warn (string? format, global::Java.Lang.Object[]? argArray)
		{
			const string __id = "warn.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString ((string?)format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging.implementation']/class[@name='DefaultLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override unsafe void Warn (string? msg, global::Java.Lang.Throwable? t)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

	}
}

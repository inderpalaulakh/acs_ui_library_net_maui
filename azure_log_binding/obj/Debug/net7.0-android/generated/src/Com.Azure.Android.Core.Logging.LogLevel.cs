using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']"
	[global::Android.Runtime.Register ("com/azure/android/core/logging/LogLevel", DoNotGenerateAcw=true)]
	public sealed partial class LogLevel : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Azure.Android.Core.Logging.LogLevel? Error {
			get {
				const string __id = "ERROR.Lcom/azure/android/core/logging/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/field[@name='INFORMATIONAL']"
		[Register ("INFORMATIONAL")]
		public static global::Com.Azure.Android.Core.Logging.LogLevel? Informational {
			get {
				const string __id = "INFORMATIONAL.Lcom/azure/android/core/logging/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/field[@name='NOT_SET']"
		[Register ("NOT_SET")]
		public static global::Com.Azure.Android.Core.Logging.LogLevel? NotSet {
			get {
				const string __id = "NOT_SET.Lcom/azure/android/core/logging/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public static global::Com.Azure.Android.Core.Logging.LogLevel? Verbose {
			get {
				const string __id = "VERBOSE.Lcom/azure/android/core/logging/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/field[@name='WARNING']"
		[Register ("WARNING")]
		public static global::Com.Azure.Android.Core.Logging.LogLevel? Warning {
			get {
				const string __id = "WARNING.Lcom/azure/android/core/logging/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/logging/LogLevel", typeof (LogLevel));

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

		internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/azure/android/core/logging/LogLevel;", "")]
		public static unsafe global::Com.Azure.Android.Core.Logging.LogLevel? FromString (string? logLevelVal)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/azure/android/core/logging/LogLevel;";
			IntPtr native_logLevelVal = JNIEnv.NewString ((string?)logLevelVal);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_logLevelVal);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_logLevelVal);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/method[@name='getLogLevel' and count(parameter)=0]"
		[Register ("getLogLevel", "()I", "")]
		public unsafe int GetLogLevel ()
		{
			const string __id = "getLogLevel.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/azure/android/core/logging/LogLevel;", "")]
		public static unsafe global::Com.Azure.Android.Core.Logging.LogLevel? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/azure/android/core/logging/LogLevel;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Logging.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.logging']/class[@name='LogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/azure/android/core/logging/LogLevel;", "")]
		public static unsafe global::Com.Azure.Android.Core.Logging.LogLevel[]? Values ()
		{
			const string __id = "values.()[Lcom/azure/android/core/logging/LogLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Azure.Android.Core.Logging.LogLevel[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Azure.Android.Core.Logging.LogLevel));
			} finally {
			}
		}

	}
}

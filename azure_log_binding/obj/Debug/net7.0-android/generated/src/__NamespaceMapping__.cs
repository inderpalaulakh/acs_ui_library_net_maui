using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.core.logging", Managed="Com.Azure.Android.Core.Logging")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.core.logging.implementation", Managed="Com.Azure.Android.Core.Logging.Implementation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.core.logging", Managed="Com.Azure.Core.Logging")]

delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif


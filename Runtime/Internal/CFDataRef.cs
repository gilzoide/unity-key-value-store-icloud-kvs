#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX || UNITY_IOS || UNITY_TVOS || UNITY_VISIONOS
using System;
using System.Runtime.InteropServices;

namespace Gilzoide.KeyValueStore.ICloudKvs.Internal
{
    public struct CFDataRef : IDisposable
    {
        private IntPtr _nativeHandle;

        [DllImport("__Internal")]
        public static extern IntPtr CFDataGetBytePtr(CFDataRef dataref);

        [DllImport("__Internal")]
        public static extern long CFDataGetLength(CFDataRef dataref);

        [DllImport("__Internal")]
        public static extern void CFRelease(IntPtr typeref);

        public byte[] GetBytes()
        {
            if (_nativeHandle == IntPtr.Zero)
            {
                return null;
            }

            IntPtr bytes = CFDataGetBytePtr(this);
            int length = checked((int) CFDataGetLength(this));
            var value = new byte[length];
            Marshal.Copy(bytes, value, 0, length);
            return value;
        }

        public string GetString()
        {
            if (_nativeHandle == IntPtr.Zero)
            {
                return null;
            }

            IntPtr bytes = CFDataGetBytePtr(this);
            int length = checked((int) CFDataGetLength(this));
            return Marshal.PtrToStringUni(bytes, length);
        }

        public void Dispose()
        {
            if (_nativeHandle != IntPtr.Zero)
            {
                CFRelease(_nativeHandle);
                _nativeHandle = IntPtr.Zero;
            }
        }
    }
}
#endif
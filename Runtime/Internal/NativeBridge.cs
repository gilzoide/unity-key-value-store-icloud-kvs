#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX || UNITY_IOS || UNITY_TVOS || UNITY_VISIONOS
using System;
using System.Runtime.InteropServices;

namespace Gilzoide.KeyValueStore.ICloudKvs.Internal
{
    public static class NativeBridge
    {
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS || UNITY_VISIONOS)
        public const string LibraryName = "__Internal";
#else
        public const string LibraryName = "KeyValueStoreICloud";
#endif

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_DeleteKey([MarshalAs(UnmanagedType.LPUTF8Str)] string key);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_HasKey([MarshalAs(UnmanagedType.LPUTF8Str)] string key);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetBool([MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.Bool)] bool value);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetBool([MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.Bool)] out bool outValue);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetInt([MarshalAs(UnmanagedType.LPUTF8Str)] string key, int value);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetInt([MarshalAs(UnmanagedType.LPUTF8Str)] string key, out int outValue);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetLong([MarshalAs(UnmanagedType.LPUTF8Str)] string key, long value);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetLong([MarshalAs(UnmanagedType.LPUTF8Str)] string key, out long outValue);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetFloat([MarshalAs(UnmanagedType.LPUTF8Str)] string key, float value);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetFloat([MarshalAs(UnmanagedType.LPUTF8Str)] string key, out float outValue);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetDouble([MarshalAs(UnmanagedType.LPUTF8Str)] string key, double value);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetDouble([MarshalAs(UnmanagedType.LPUTF8Str)] string key, out double outValue);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetBytes([MarshalAs(UnmanagedType.LPUTF8Str)] string key, byte[] bytes, int length);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetBytes([MarshalAs(UnmanagedType.LPUTF8Str)] string key, out CFDataRef outValue);

        [DllImport(LibraryName)]
        public static extern void KeyValueStoreICloudKvs_SetString([MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.LPUTF8Str)] string cStr);

        [DllImport(LibraryName)]
        public static extern bool KeyValueStoreICloudKvs_TryGetString([MarshalAs(UnmanagedType.LPUTF8Str)] string key, out CFDataRef outValue);
    }
}
#endif
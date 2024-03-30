#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX || UNITY_IOS || UNITY_TVOS || UNITY_VISIONOS
using Gilzoide.KeyValueStore.ICloudKvs.Internal;

namespace Gilzoide.KeyValueStore.ICloudKvs
{
    public class ICloudKeyValueStore : IKeyValueStore
    {
        public void DeleteAll()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteKey(string key)
        {
            NativeBridge.KeyValueStoreICloudKvs_DeleteKey(key);
        }

        public bool HasKey(string key)
        {
            return NativeBridge.KeyValueStoreICloudKvs_HasKey(key);
        }

        public void SetBool(string key, bool value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetBool(key, value);
        }

        public void SetBytes(string key, byte[] value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetBytes(key, value, value.Length);
        }

        public void SetDouble(string key, double value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetDouble(key, value);
        }

        public void SetFloat(string key, float value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetFloat(key, value);
        }

        public void SetInt(string key, int value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetInt(key, value);
        }

        public void SetLong(string key, long value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetLong(key, value);
        }

        public void SetString(string key, string value)
        {
            NativeBridge.KeyValueStoreICloudKvs_SetString(key, value);
        }

        public bool TryGetBool(string key, out bool value)
        {
            return NativeBridge.KeyValueStoreICloudKvs_TryGetBool(key, out value);
        }

        public bool TryGetBytes(string key, out byte[] value)
        {
            if (NativeBridge.KeyValueStoreICloudKvs_TryGetBytes(key, out CFDataRef data))
            {
                using (data)
                {
                    value = data.GetBytes();
                    return true;
                }
            }
            else
            {
                value = null;
                return false;
            }
        }

        public bool TryGetDouble(string key, out double value)
        {
            return NativeBridge.KeyValueStoreICloudKvs_TryGetDouble(key, out value);
        }

        public bool TryGetFloat(string key, out float value)
        {
            return NativeBridge.KeyValueStoreICloudKvs_TryGetFloat(key, out value);
        }

        public bool TryGetInt(string key, out int value)
        {
            return NativeBridge.KeyValueStoreICloudKvs_TryGetInt(key, out value);
        }

        public bool TryGetLong(string key, out long value)
        {
            return NativeBridge.KeyValueStoreICloudKvs_TryGetLong(key, out value);
        }

        public bool TryGetString(string key, out string value)
        {
            if (NativeBridge.KeyValueStoreICloudKvs_TryGetString(key, out CFDataRef data))
            {
                using (data)
                {
                    value = data.GetString();
                    return true;
                }
            }
            else
            {
                value = null;
                return false;
            }
        }
    }
}
#endif
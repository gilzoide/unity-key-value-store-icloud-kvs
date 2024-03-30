#import <Foundation/Foundation.h>

static NSString* toNSString(const char *cStr) {
    return [NSString stringWithCString:cStr encoding:NSUTF8StringEncoding];
}

///////////////////////////////////////////////////////////
// Exported functions
///////////////////////////////////////////////////////////
void KeyValueStoreICloudKvs_DeleteKey(const char *key) {
    [NSUbiquitousKeyValueStore.defaultStore removeObjectForKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_HasKey(const char *key) {
    return [NSUbiquitousKeyValueStore.defaultStore objectForKey:toNSString(key)];
}

void KeyValueStoreICloudKvs_SetBool(const char *key, int value) {
    [NSUbiquitousKeyValueStore.defaultStore setBool:value forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetBool(const char *key, int *outValue) {
    id value = [NSUbiquitousKeyValueStore.defaultStore objectForKey:toNSString(key)];
    if ([value isKindOfClass:NSNumber.class]) {
        *outValue = [value boolValue];
        return true;
    }
    else {
        *outValue = 0;
        return false;
    }
}

void KeyValueStoreICloudKvs_SetInt(const char *key, int value) {
    [NSUbiquitousKeyValueStore.defaultStore setLongLong:value forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetInt(const char *key, int *outValue) {
    id value = [NSUbiquitousKeyValueStore.defaultStore objectForKey:toNSString(key)];
    if ([value isKindOfClass:NSNumber.class]) {
        *outValue = [value intValue];
        return true;
    }
    else {
        *outValue = 0;
        return false;
    }
}

void KeyValueStoreICloudKvs_SetLong(const char *key, long value) {
    [NSUbiquitousKeyValueStore.defaultStore setLongLong:value forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetLong(const char *key, long *outValue) {
    id value = [NSUbiquitousKeyValueStore.defaultStore objectForKey:toNSString(key)];
    if ([value isKindOfClass:NSNumber.class]) {
        *outValue = [value longValue];
        return true;
    }
    else {
        *outValue = 0;
        return false;
    }
}

void KeyValueStoreICloudKvs_SetFloat(const char *key, float value) {
    [NSUbiquitousKeyValueStore.defaultStore setDouble:value forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetFloat(const char *key, float *outValue) {
    id value = [NSUbiquitousKeyValueStore.defaultStore objectForKey:toNSString(key)];
    if ([value isKindOfClass:NSNumber.class]) {
        *outValue = [value floatValue];
        return true;
    }
    else {
        *outValue = 0;
        return false;
    }
}

void KeyValueStoreICloudKvs_SetDouble(const char *key, double value) {
    [NSUbiquitousKeyValueStore.defaultStore setDouble:value forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetDouble(const char *key, double *outValue) {
    id value = [NSUbiquitousKeyValueStore.defaultStore objectForKey:toNSString(key)];
    if ([value isKindOfClass:NSNumber.class]) {
        *outValue = [value doubleValue];
        return true;
    }
    else {
        *outValue = 0;
        return false;
    }
}

void KeyValueStoreICloudKvs_SetBytes(const char *key, const void *bytes, int length) {
    [NSUbiquitousKeyValueStore.defaultStore setData:[NSData dataWithBytes:bytes length:length] forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetBytes(const char *key, CFDataRef *outValue) {
    NSData* value = [NSUbiquitousKeyValueStore.defaultStore dataForKey:toNSString(key)];
    if (value) {
        *outValue = CFBridgingRetain(value);
        return true;
    }
    else {
        *outValue = nil;
        return false;
    }
}

void KeyValueStoreICloudKvs_SetString(const char *key, const char *cStr) {
    [NSUbiquitousKeyValueStore.defaultStore setString:toNSString(cStr) forKey:toNSString(key)];
}

bool KeyValueStoreICloudKvs_TryGetString(const char *key, CFDataRef *outValue) {
    NSString* value = [NSUbiquitousKeyValueStore.defaultStore stringForKey:toNSString(key)];
    if (value) {
        *outValue = CFBridgingRetain([value dataUsingEncoding:NSUTF16StringEncoding]);
        return true;
    }
    else {
        *outValue = nil;
        return false;
    }
}

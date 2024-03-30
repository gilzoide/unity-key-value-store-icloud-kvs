# iCloud Key-Value Store for Unity
[Key-Value Store](https://github.com/gilzoide/unity-key-value-store) implementation backed by [iCloud KVS](https://developer.apple.com/documentation/foundation/nsubiquitouskeyvaluestore).


## Features
- [ICloudKeyValueStore](Runtime/ICloudKeyValueStore.cs): Key-Value Store implementation that stores data using iCloud KVS.
- Supports macOS, iOS, tvOS and visionOS


## Dependencies
- [Key-Value Store](https://github.com/gilzoide/unity-key-value-store): interface used by this implementation, which also provides custom object serialization out of the box.


## How to install
Either:
- Install using the [Unity Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html) with the following URL:
  ```
  https://github.com/gilzoide/unity-key-value-store-icloud-kvs.git#1.0.0-preview1
  ```
- Clone this repository or download a snapshot of it directly inside your project's `Assets` or `Packages` folder.


## Basic usage
```cs
using Gilzoide.KeyValueStore.ICloudKvs;
using UnityEngine;

// 1. Instantiate a ICloudKeyValueStore
var kvs = new ICloudKeyValueStore();


// 2. Set/Get/Delete values
kvs.SetBool("finishedTutorial", true);
kvs.SetString("username", "gilzoide");

Debug.Log("Checking if values exist: " + kvs.HasKey("username"));
Debug.Log("Getting values: " + kvs.GetInt("username"));
Debug.Log("Getting values with fallback: " + kvs.GetString("username", "default username"));
// Like C# Dictionary, this idiom returns a bool if the key is found
if (kvs.TryGetString("someKey", out string foundValue))
{
    Debug.Log("'someKey' exists: " + foundValue);
}

kvs.DeleteKey("someKey");
```
LINKFLAGS += -shared -framework Foundation

macOS/KeyValueStoreICloud.dylib: CFLAGS += -arch arm64 -arch x86_64
macOS/KeyValueStoreICloud.dylib: source/KeyValueStoreICloud.m
	$(CC) -o $@ $< $(CFLAGS) $(LINKFLAGS)
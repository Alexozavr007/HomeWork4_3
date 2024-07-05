
for (int i = 0; i < 100; i++) {
    if (!Directory.Exists($"Folder_{i}")) {
        Directory.CreateDirectory($"Folder_{i}");
    }
}
for  (int i = 0; i < 100; i++) {
    Directory.Delete($"Folder_{i}");
}
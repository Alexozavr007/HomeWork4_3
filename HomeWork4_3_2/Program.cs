var file = new FileInfo("test.txt");

StreamWriter writer = file.CreateText();
writer.WriteLine("car");
writer.Close();

StreamReader reader = file.OpenText();
var lineFromFile = reader.ReadLine();
Console.WriteLine($"Line from file: {lineFromFile}");
reader.Close();

var opts = new EnumerationOptions { 
    IgnoreInaccessible = true,
    RecurseSubdirectories = true,
};

string? foundFullFilePath = null;
foreach (var item in System.IO.Directory.EnumerateFiles(@"c:\", "test.txt", opts)) {
    foundFullFilePath = item;
    break;
}

if (foundFullFilePath == null) {
    Console.WriteLine("File not found");
} else {
    Console.WriteLine($"File found: {foundFullFilePath}");
}
using System;
using System.IO;
String directoryPath = "C:\\";
List<string> dirFolders = new List<string>();
while(true){
    System.Console.WriteLine("Write the file path (C:// is already included and your previous entries)");
    directoryPath += "/"+Console.ReadLine();
    if(Directory.Exists(directoryPath)){
        string[] files = Directory.GetFileSystemEntries(directoryPath);
        foreach (string file in files){
            dirFolders.Add(file);
        }
    }
    else{
        System.Console.WriteLine("Directory not found.");
        System.Console.WriteLine("Path Reseted Write The File Path (C:// is already included)");
        directoryPath = "C://"+Console.ReadLine();
    }
}
using System;
using System.IO;
bool x = true; //keeps the while loop going
String directoryPath = "C:\\";
while (x){
    System.Console.WriteLine("Write the file path (C:// is already included and your previous entries)");
    directoryPath += "/"+Console.ReadLine();
    
    if (Directory.Exists(directoryPath)){
            string[] files = Directory.GetFileSystemEntries(directoryPath);
            foreach (string file in files){
            System.Console.WriteLine(file);
        }
    }
    else{
        System.Console.WriteLine("Directory not found.");
        System.Console.WriteLine("Path Reseted Write The File Path (C:// is already included)");
        directoryPath = "C://"+Console.ReadLine();
    }
}
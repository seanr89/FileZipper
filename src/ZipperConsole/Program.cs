using System.Runtime.InteropServices;
using ZipperConsole;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Running: Zipper!");

//Simple sleeper
Thread.Sleep(500);

string path = System.Runtime.InteropServices.RuntimeInformation
                                        .IsOSPlatform(OSPlatform.Windows) ? "../AppFiles": "..//MacFiles";
// If directory does not exist, don't even try   
if(!Directory.Exists(path))
{
    Console.WriteLine("Path is invalid");
    Environment.Exit(1);
}

int count = FileHandler.getCountOfFilesInFolder(path);
Console.WriteLine($"A total of {count} files are available to compress");

Console.WriteLine("App Complete");
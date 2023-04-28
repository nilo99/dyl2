using System.Diagnostics;
using System.IO.Compression;
using System.Net;

WebClient webClient = new WebClient();
var client = new WebClient();

try
{
    System.Threading.Thread.Sleep(5000);
    File.Delete(@".\RGB_Fade.dll");
    File.Delete(@".\Siticone.Desktop.UI.dll");
    File.Delete(@".\Siticone.UI.dll");
    File.Delete(@".\swed64.dll");
    File.Delete(@".\trainerrr.deps.json");
    File.Delete(@".\trainerrr.dll");
    File.Delete(@".\trainerrr.exe");
    File.Delete(@".\trainerrr.pdb");
    File.Delete(@".\trainerrr.runtimeconfig.json");
    client.DownloadFile("yourfilelink", @"Trainer.zip");
    string zipPath = @".\Trainer.zip";
    string extractPath = @".\";
    ZipFile.ExtractToDirectory(zipPath, extractPath);
    File.Delete(@".\Trainer.zip");
    Process.Start(@".\trainerrr.exe");
    System.Environment.Exit(0);
}
catch
{
    Console.WriteLine("No Internet");
    System.Environment.Exit(0);
}

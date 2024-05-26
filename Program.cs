using System.IO;
using System.IO.Compression;
using System.Text.Json;
using UploadDrive;

string folderId = "1jWgakpLKDVNOcVyojmjeuhZwAa5yyMAm";
string folderUploadPath = "D:\\YTB\\c1_UseDriveAPI\\Test\\I save your life.txt";
Extend.UploadFileToGoogleDrive(folderId,folderUploadPath);
Console.WriteLine("====");
var listFile = Extend.GetLisFiles(folderId);
foreach (var file in listFile)
{
    Console.WriteLine($"{file.Name} {file.Id}");
}
Extend.DeleteFile(folderId);
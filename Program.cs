using FacadeDesignPattern.Services.Implementations;
using FacadeDesignPattern.Services.Interfaces;

Console.WriteLine("Specify the the name of file to be uploaded:");
var fullPath = Console.ReadLine();

if(fullPath is not null && !string.IsNullOrWhiteSpace(fullPath))
{
    IFileFacadeService fileFacadeService = new FileFacadeService();
    try
    {
        fileFacadeService.UploadTextFile(fullPath.Trim());    
    }
    catch (System.Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
    Console.WriteLine("Invalid fullPath");

// /Users/tallesvaliatti/Projects/FacadeDesignPattern/Example.txt 
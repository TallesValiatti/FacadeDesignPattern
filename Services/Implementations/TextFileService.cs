using FacadeDesignPattern.Services.Interfaces;

namespace FacadeDesignPattern.Services.Implementations
{
    public class TextFileService : ITextFileService
    {
        public (FileStream, string) ReadTextFile(string fullPath)
        {
            var fileInfo = new FileInfo(fullPath);

            if(!fileInfo.Exists)
                throw new Exception("Invalid fullPath");

            if(!string.Equals(fileInfo.Extension, ".txt"))
                throw new Exception("Invalid extension");

            Console.WriteLine("Reading file ...");
            var stream =  File.OpenRead(fullPath);
            Console.WriteLine("Done");

            return (stream, fileInfo.Name);
        }
    }
}
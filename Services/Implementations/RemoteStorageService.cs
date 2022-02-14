using FacadeDesignPattern.Services.Interfaces;

namespace FacadeDesignPattern.Services.Implementations
{
    public class RemoteStorageService : IRemoteStorageService
    {
        public bool Exists(string fileName)
        {
            // Verify if the file exists on remote storage 
            Console.WriteLine("Verifing if the blob exists on remote storage ...");
            return false;
        }

        public void UploadFile(string fileName, Stream stream)
        {
           // Upload the file to remote storage
            Console.WriteLine($"Uploading {fileName} ...");
            Console.WriteLine("Done");
        }
    }
}
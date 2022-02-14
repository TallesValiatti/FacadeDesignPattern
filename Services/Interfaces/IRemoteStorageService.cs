namespace FacadeDesignPattern.Services.Interfaces
{
    public interface IRemoteStorageService
    {
        bool Exists(string fileName);
        void UploadFile(string fileName, Stream stream);
    }
}
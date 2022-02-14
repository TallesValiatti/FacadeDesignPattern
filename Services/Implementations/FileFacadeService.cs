using FacadeDesignPattern.Services.Interfaces;

namespace FacadeDesignPattern.Services.Implementations
{
    public class FileFacadeService : IFileFacadeService
    {
        private IRemoteStorageService _remoteStorageService;
        private ITextFileService _textFileService;
        public FileFacadeService()
        {
            _remoteStorageService = new RemoteStorageService();
            _textFileService = new TextFileService();
        }
        public void UploadTextFile(string fullPath)
        {
            var fileData = _textFileService.ReadTextFile(fullPath);
            var stream = fileData.Item1;
            var fileName = fileData.Item2;

            if(_remoteStorageService.Exists(fileName))
                throw new Exception("File already exists on remote storage");

            _remoteStorageService.UploadFile(fileName, stream);
        }
    }
}
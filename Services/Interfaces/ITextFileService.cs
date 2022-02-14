namespace FacadeDesignPattern.Services.Interfaces
{
    public interface ITextFileService
    {
        (FileStream, string) ReadTextFile(string fullPath);
    }
}
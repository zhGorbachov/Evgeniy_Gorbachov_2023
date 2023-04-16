namespace ClassLibrary1.Interfaces;

public interface IOwner
{
    public void DeleteFile(string filename);
    public void GetDataFromFile(string filename);
}
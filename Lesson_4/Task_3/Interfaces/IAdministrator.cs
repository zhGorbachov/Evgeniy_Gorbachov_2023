namespace ClassLibrary1.Interfaces;

public interface IAdministrator
{
    public void WriteToFile(string filename);
    public void CheckFile(string filename);
    public void SaveToFile(string filename);
}
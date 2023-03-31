namespace LiskovSubstitution;

public interface IUser
{
    public string ReadFromFile(string filename);
    public void DownloadFile(string filename);
    public void CopyFile(string filename);
    public Guid CheckRole(Guid role);
}
namespace LiskovSubstitution;

public interface IAdministrator : IUser
{
    public void WriteToFile(string filename);
    public void DeleteFile(string filename);
    public void CheckFile(string filename);
    public void SaveToFile(string filename);
    public Guid CheckUser(Guid user);
}
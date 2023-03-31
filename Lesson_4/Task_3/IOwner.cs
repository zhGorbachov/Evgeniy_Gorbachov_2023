namespace LiskovSubstitution;

public interface IOwner : IAdministrator
{
    public void GetDataFromFile(string filename);
}
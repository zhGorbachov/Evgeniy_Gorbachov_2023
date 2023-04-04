namespace LiskovSubstitution;

public class Owner : Administrator
{
    public override void GetDataFromFile(string filename)
    {
        base.GetDataFromFile(filename);
    }

    public override void DeleteFile(string filename)
    {
        base.DeleteFile(filename);
    }
    
    public override Guid CheckRole(Guid user)
    {
        Console.WriteLine("User checked");
        return user;
    }
    
    public override Guid CheckUser(Guid user)
    {
        Console.WriteLine("User checked");
        return Guid.NewGuid();
    }
}